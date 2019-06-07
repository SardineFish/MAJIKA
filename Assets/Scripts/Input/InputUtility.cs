using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public static class InputUtility
{
    public static IEnumerator WaitPerform(this InputAction action)
    {
        bool triggerd = false;
        action.performed += ctx => triggerd = true;
        System.Action<InputAction.CallbackContext> callback = (ctx) =>
        {
            triggerd = true;
        };
        action.performed += callback;
        while (!triggerd)
        {
            yield return null;
        }
        action.performed -= callback;
        yield break;
    }

    public static bool IsPerformed(this InputAction action)
        => action.phase == InputActionPhase.Performed;

    public static bool WasPressedThisFrame(this InputAction action)
    {
        return action.controls
            .Select(control => control as ButtonControl)
            .Where(control => control != null)
            .Any(control => control.wasPressedThisFrame);
    }
}