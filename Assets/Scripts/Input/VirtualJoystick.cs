using UnityEngine;
using System.Collections;
using UnityEngine.Experimental.Input.Plugins.OnScreen;


public class VirtualJoystick : OnScreenControl
{
    VariableJoystick joystick;

    private void Start()
    {
        joystick = GetComponent<VariableJoystick>();
    }
    private void FixedUpdate()
    {
        SendValueToControl<Vector2>(new Vector2(joystick.Horizontal, joystick.Vertical));
    }
}
