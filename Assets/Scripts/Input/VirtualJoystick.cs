using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem.Plugins.OnScreen;


public class VirtualJoystick : OnScreenControl
{
    VariableJoystick joystick;
    protected override string controlPathInternal { get; set; }

    private void Start()
    {
        joystick = GetComponent<VariableJoystick>();
    }
    private void FixedUpdate()
    {
        SendValueToControl<Vector2>(new Vector2(joystick.Horizontal, joystick.Vertical));
    }
}
