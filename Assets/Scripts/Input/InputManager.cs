using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Experimental.Input;
using UnityEngine.Experimental.Input.Utilities;

[ExecuteInEditMode]
public class InputManager_Legacy : Singleton<InputManager_Legacy> {
    public const int SkillCount = 4;

    public InputAction MovementAction;
    
    public InputAction JumpAction;
    public InputAction ClimbAction;
    public InputAction InteractAction;

    public InputAction InventoryAction;

    public InputAction AcceptAction;
    public InputAction BackAction;
    public InputAction AnyKey;

    public InputAction SkillAction1;
    public InputAction SkillAction2;
    public InputAction SkillAction3;
    public InputAction SkillAction4;

    public IEnumerable<InputAction> AllActions
        => this.GetType().GetFields()
            .Where(field => field.FieldType == typeof(InputAction))
            .Select(field => field.GetValue(this) as InputAction);

    private InputAction[] skillActionList;

    public Dictionary<InputAction, InputState> InputActionWrappers = new Dictionary<InputAction, InputState>();

    private void OnEnable()
    {
        AllActions.ForEach(action => action.Enable());
    }

    protected override void Awake()
    {
        base.Awake();
        skillActionList = new InputAction[] {
            SkillAction1,
            SkillAction2,
            SkillAction3,
            SkillAction4
        };
        AllActions.ForEach(action => this.InputActionWrappers[action] = new InputState(action));
    }

    public void Update()
    {
        InputActionWrappers.ForEach(pair => pair.Value.Update());
    }

    private void FixedUpdate()
    {
        InputActionWrappers.ForEach(pair => pair.Value.FixedUpdate());
    }

    public Vector2 GetMovement()
    {
        return GetInputValue<Vector2>(MovementAction);
        // return new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }

    public IEnumerator WaitForAction(InputAction action)
    {
        while (!GetAction(action))
            yield return null;
    }

    public bool GetAction(InputAction action)
    {
        return InputActionWrappers[action].Phase == InputActionPhase.Started || InputActionWrappers[action].Phase == InputActionPhase.Performed;
    }

    public bool GetActionStarted(InputAction action) 
        => InputActionWrappers[action].GetPhaseChanged(InputActionPhase.Started);

    public bool GetActionPerformed(InputAction action) 
        => InputActionWrappers[action].GetPhaseChanged(InputActionPhase.Performed);

    public bool GetActionCancelled(InputAction action)
        => InputActionWrappers[action].GetPhaseChanged(InputActionPhase.Cancelled);

    public T GetInputValue<T>(InputAction action) where T : struct
        => InputActionWrappers[action].ReadValue<T>();

    public int GetSkillIndex()
    {
        var keys = new KeyCode[]
        {
            KeyCode.Alpha1,
            KeyCode.Alpha2,
            KeyCode.Alpha3,
            KeyCode.Alpha4,
            KeyCode.Alpha5,
            KeyCode.Alpha6,
            KeyCode.Alpha7,
            KeyCode.Alpha8,
            KeyCode.Alpha9,
            KeyCode.Alpha0,
            KeyCode.Minus,
            KeyCode.Equals,
        };
        var actions = new InputAction[]
        {
            SkillAction1,
            SkillAction2,
            SkillAction3,
            SkillAction4,
        };
        for (var i = 0; i < actions.Length; i++)
            if (GetAction(actions[i]))
                return i;
        for(var i = 0; i < keys.Length; i++)
        {
            if (Input.GetKeyDown(keys[i]))
                return i;
        }
        return -1;
        /*
        for(var i = 0; i < skillActionList.Length; i++)
        {
            if (GetAction(skillActionList[i]))
                return i;
        }
        return -1;*/

    }
}
