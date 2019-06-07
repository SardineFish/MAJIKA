using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem.Plugins.OnScreen;
using UnityEngine.InputSystem.Layouts;


public class VirtualJoystick : OnScreenControl
{
    VariableJoystick joystick;
    [SerializeField]
    [InputControl(layout = "Vector2")]
    private string m_controlPath;
    protected override string controlPathInternal { get=>m_controlPath; set=>m_controlPath = value; }

    private void Start()
    {
        joystick = GetComponent<VariableJoystick>();
    }
    private void FixedUpdate()
    {
        SendValueToControl<Vector2>(new Vector2(joystick.Horizontal, joystick.Vertical));
    }
}
