using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem;
using System.Linq;

public enum DeviceClass
{
    Keyboard,
    Gamepad,
    TouchScreen,
};
public class InputManager : Singleton<InputManager>
{
    private void OnEnable()
    {
        Controller.Enable();
    }
    [Tooltip("Input action assets")]
    public MAJIKAInput Controller;

    public DeviceClass CurrentActiveDeviceType
    {
        get;
        private set;
    }

    InputAction gamepad;
    DeviceChangeDetector DeviceChangeDetector;

    private void Awake()
    {
        DeviceChangeDetector = new DeviceChangeDetector();
        DeviceChangeDetector.OnDeviceChanged += DeviceChangeDetector_OnDeviceChanged;
        Controller = new MAJIKAInput();
        CurrentActiveDeviceType = DeviceClass.TouchScreen;
    }

    private void DeviceChangeDetector_OnDeviceChanged(DeviceClass device)
    {
        Debug.Log(device);
        CurrentActiveDeviceType = device;
    }

    public MAJIKAInput.ActionsActions Actions => Controller.Actions;

    public MAJIKAInput.GamePlayActions GamePlay => Controller.GamePlay;

    public bool GetTouch()
    {
        return Input.touches.Any(touch => touch.phase == UnityEngine.TouchPhase.Began);
    }
}
