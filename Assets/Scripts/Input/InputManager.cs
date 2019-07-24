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

    private void Awake()
    {
        gamepad = new InputAction(binding: "<Gamepad>/*");
        gamepad.performed += (ctx) =>
        {
            Debug.LogError(ctx.control.path);
        };
        InputSystem.onDeviceChange += InputSystem_onDeviceChange;
        Controller = new MAJIKAInput();
    }

    private void InputSystem_onDeviceChange(InputDevice device, InputDeviceChange change)
    {
        if(change == InputDeviceChange.StateChanged)
        {
            if (Utility.GetGenericPlatform(Application.platform) == GenericPlatform.Mobile)
                CurrentActiveDeviceType = DeviceClass.TouchScreen;
            else if (device.description.deviceClass == "Keyboard")
                CurrentActiveDeviceType = DeviceClass.Keyboard;
            else if (device.description.deviceClass == "Mouse")
                return;
            else
                CurrentActiveDeviceType = DeviceClass.Gamepad;
        }
    }

    public MAJIKAInput.ActionsActions Actions => Controller.Actions;

    public MAJIKAInput.GamePlayActions GamePlay => Controller.GamePlay;

    public bool GetTouch()
    {
        return Input.touches.Any(touch => touch.phase == TouchPhase.Began);
    }
}
