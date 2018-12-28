using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Experimental.Input;
using UnityEngine.Experimental.Input.Utilities;

[ExecuteInEditMode]
public class InputManager : Singleton<InputManager> {
    public Vector2 Movement;
    public const int SkillCount = 4;
    public bool Jumped = false;
    public bool Climbed = false;

    public InputAction MovementAction;
    
    public InputAction JumpAction;
    public InputAction ClimbAction;
    public InputAction InteractAction;

    public InputAction AcceptAction;
    public InputAction BackAction;
    public InputAction AnyKey;

    public InputAction SkillAction1;
    public InputAction SkillAction2;
    public InputAction SkillAction3;
    public InputAction SkillAction4;

    private InputAction[] skillActionList;

    private void OnEnable()
    {
        AnyKey.Enable();
        MovementAction.Enable();
        JumpAction.Enable();
        ClimbAction.Enable();
        InteractAction.Enable();
        AcceptAction.Enable();
        BackAction.Enable();
        SkillAction1.Enable();
        SkillAction2.Enable();
        SkillAction3.Enable();
        SkillAction4.Enable();
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
        MovementAction.performed += ctx =>
        {
            Movement = ctx.ReadValue<Vector2>();
        };
        JumpAction.performed += ctx =>
        {
            if (ctx.ReadValue<float>() > 0.5)
                Jumped = true;
            else
                Jumped = false;
        };
        ClimbAction.performed += ctx =>
        {
            if (ctx.ReadValue<float>() > 0.5)
                Climbed = true;
            else
                Climbed = false;
        };
    }

    public void Update()
    {
    }

    public Vector2 GetMovement()
    {
        return new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }

    public IEnumerator WaitForAction(InputAction action)
    {
        while (!GetAction(action))
            yield return null;
    }

    public bool GetAction(InputAction action)
    {
        return action.phase == InputActionPhase.Started;
    }

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
