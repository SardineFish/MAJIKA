using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.Experimental.Input;

public class InputState
{
    public InputAction Action;

    private DoubleBuffer<InputActionPhase> PhaseBuffer = new DoubleBuffer<InputActionPhase>();

    private DoubleBuffer<InputActionPhase> FixedUpdatePhaseBuffer = new DoubleBuffer<InputActionPhase>();

    private DoubleBuffer<InputActionPhase> UpdatePhaseTrack = new DoubleBuffer<InputActionPhase>();

    private DoubleBuffer<InputActionPhase> FixedUpdatePhaseTrack = new DoubleBuffer<InputActionPhase>();

    private DoubleBuffer<InputAction.CallbackContext?> ctxUpdate = new DoubleBuffer<InputAction.CallbackContext?>();

    private DoubleBuffer<InputAction.CallbackContext?> ctxFixedUpdate = new DoubleBuffer<InputAction.CallbackContext?>();

    private DoubleBuffer<InputAction.CallbackContext?> ctxLast = new DoubleBuffer<InputAction.CallbackContext?>();

    public InputActionPhase Phase => PhaseBuffer.Value;

    public InputActionPhase PhaseFixedUpdate => FixedUpdatePhaseBuffer.Value;
    

    public InputState(InputAction action)
    {
        action.started += ctx =>
        {
            FixedUpdatePhaseBuffer.Value = PhaseBuffer.Value = UpdatePhaseTrack.Value = FixedUpdatePhaseTrack.Value = InputActionPhase.Started;
            ctxUpdate.Value = ctxFixedUpdate.Value = ctxLast.Value = ctx;
        };
        action.performed += ctx =>
        {
            FixedUpdatePhaseBuffer.Value = PhaseBuffer.Value = UpdatePhaseTrack.Value = FixedUpdatePhaseTrack.Value = InputActionPhase.Performed;
            ctxUpdate.Value = ctxFixedUpdate.Value = ctxLast.Value = ctx;
        };
        action.cancelled += ctx =>
        {
            FixedUpdatePhaseBuffer.Value = PhaseBuffer.Value = UpdatePhaseTrack.Value = FixedUpdatePhaseTrack.Value = InputActionPhase.Performed;
            ctxUpdate.Value = ctxFixedUpdate.Value = ctxLast.Value = ctx;
        };
    }

    internal void Update()
    {
        if (PhaseBuffer.Value != InputActionPhase.Started || PhaseBuffer.BackendValue != InputActionPhase.Waiting)
            PhaseBuffer.Update();
        UpdatePhaseTrack.Update();
        
        PhaseBuffer.Value = InputActionPhase.Waiting;
        UpdatePhaseTrack.Value = InputActionPhase.Waiting;

        ctxLast.Update();
        ctxUpdate.Update();
        ctxUpdate.Value = null;
    }

    internal void FixedUpdate()
    {
        if (FixedUpdatePhaseBuffer.Value != InputActionPhase.Started || FixedUpdatePhaseBuffer.BackendValue != InputActionPhase.Waiting)
            FixedUpdatePhaseBuffer.Update();
        FixedUpdatePhaseTrack.Update();

        FixedUpdatePhaseTrack.Value = InputActionPhase.Waiting;
        FixedUpdatePhaseTrack.Value = InputActionPhase.Waiting;

        ctxFixedUpdate.Update();
        ctxFixedUpdate.Value = null;

    }

    /// <summary>
    /// Get changed value since last update
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public T ReadUpdateValue<T>() where T : struct
    {
        return ctxUpdate.Value?.ReadValue<T>() ?? default;
    }

    /// <summary>
    /// Get changed value since last fixed update
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public T ReadFixedUpdateValue<T>() where T : struct
    {
        return ctxFixedUpdate.Value?.ReadValue<T>() ?? default;
    }

    /// <summary>
    /// Get current value
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public T ReadValue<T>() where T : struct
    {
        return ctxLast.Value?.ReadValue<T>() ?? default;
    }

    public bool GetPhaseChanged(InputActionPhase phase)
    {
        return UpdatePhaseTrack.Value == phase;
    }
}