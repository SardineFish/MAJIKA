using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[ExecuteInEditMode]
public class InputManager : Singleton<InputManager> {
    public KeyCode KeyJump;
    public KeyCode KeyHold;
    public KeyCode KeyAttack1;
    public KeyCode KeyAttack2;
    public KeyCode KeyAttack3;
    public KeyCode keyAttack4;

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
}
