using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[ExecuteInEditMode]
public class InputManager : Singleton<InputManager> {
    public KeyCode KeyJump;
    public KeyCode KeyClimb;
    public KeyCode[] SkillsKeyCode = new KeyCode[0];

    public void Update()
    {
        Enum.GetValues(typeof(KeyCode)).Cast<KeyCode>().ForEach((key) =>
        {
            if (Input.GetKeyDown(key))
            {
                Debug.Log(key);
            }
        });
    }

    public Vector2 GetMovement()
    {
        return new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }

    public bool GetKey(KeyCode key)
    {
        return Input.GetKeyDown(key);
    }

    public int GetSkillIndex()
    {
        for(var i = 0; i < SkillsKeyCode.Length; i++)
        {
            if (Input.GetKeyDown(SkillsKeyCode[i]))
                return i;
        }
        return -1;
    }
}
