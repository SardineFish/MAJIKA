using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem.OnScreen;

public class VirtualJoystickAction : OnScreenActionControl
{
    public Vector2 Direction;
    public float Threshold = 0.8f;

    VariableJoystick joystick;

    private void Start()
    {
        joystick = GetComponent<VariableJoystick>();
    }
    private void FixedUpdate()
    {
        var val = new Vector2(joystick.Horizontal, joystick.Vertical);
        var dot = Vector2.Dot(Direction, val);
        if (dot >= Threshold)
        {
            SendValueToControl<float>(1);
        }
        else
            SendValueToControl<float>(0);
    }
}
