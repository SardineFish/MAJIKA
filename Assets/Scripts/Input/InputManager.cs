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

    public InputAction MovementAction;

    public InputAction JumpAction;
    public InputAction ClimbAction;

    public InputAction SkillAction1;
    public InputAction SkillAction2;
    public InputAction SkillAction3;
    public InputAction SkillAction4;

    private InputAction[] skillActionList;

    private void OnEnable()
    {
        MovementAction.Enable();
        JumpAction.Enable();
        ClimbAction.Enable();
        SkillAction1.Enable();
        SkillAction2.Enable();
        SkillAction3.Enable();
        SkillAction4.Enable();
    }

    private void Awake()
    {
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
    }

    public void Update()
    {
        Enum.GetValues(typeof(KeyCode)).Cast<KeyCode>().ForEach((key) =>
        {
            if (Input.GetKeyDown(key))
            {
                //Debug.Log(key);
            }
        });
    }

    public Vector2 GetMovement()
    {
        return new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }

    public bool GetAction(InputAction action)
    {
        return action.phase == InputActionPhase.Started;
    }

    public int GetSkillIndex()
    {
        for(var i = 0; i < skillActionList.Length; i++)
        {
            if (GetAction(skillActionList[i]))
                return i;
        }
        return -1;

    }
}
