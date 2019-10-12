using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem.OnScreen;
using UnityEngine.InputSystem.Layouts;


public class VirtualJoystick : OnScreenControl
{
    public bool InvertX = false;
    public bool InvertY = false;
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
        SendValueToControl<Vector2>(new Vector2(
            joystick.Horizontal * (InvertX ? -1 : 1), 
            joystick.Vertical * (InvertY ? -1: 1)));
    }

}
