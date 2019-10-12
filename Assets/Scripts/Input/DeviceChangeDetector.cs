using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem;
using System;

public class DeviceChangeDetector : MonoBehaviour
{
    DeviceClass currentInputDevice = DeviceClass.TouchScreen;
    public DeviceClass CurrentInputDevice
    {
        get => currentInputDevice;
        set
        {
            if(value != currentInputDevice)
            {
                currentInputDevice = value;
                OnDeviceChanged?.Invoke(currentInputDevice);
            }
        }
    }
    public event Action<DeviceClass> OnDeviceChanged;

    GameInputCallback inputCallback;
    ActionInputCallback actionInputCallback;
    MAJIKAInput inputInstance;

    public DeviceChangeDetector()
    {
        inputCallback = new GameInputCallback();
        actionInputCallback = new ActionInputCallback();

        inputCallback.DeviceCallback += DeviceCallback;
        actionInputCallback.DeviceCallback += DeviceCallback;
        inputInstance = new MAJIKAInput();
        inputInstance.Actions.SetCallbacks(actionInputCallback);
        inputInstance.GamePlay.SetCallbacks(inputCallback);
        inputInstance.Enable();
    }

    private void DeviceCallback(InputDevice device)
    {
        if (Utility.GetGenericPlatform(Application.platform) == GenericPlatform.Mobile)
            CurrentInputDevice = DeviceClass.TouchScreen;
        else if (device.description.deviceClass == "Keyboard")
            CurrentInputDevice = DeviceClass.Keyboard;
        else if (device.description.deviceClass == "Mouse")
            return;
        else
            CurrentInputDevice = DeviceClass.Gamepad;
    }
    public class ActionInputCallback : MAJIKAInput.IActionsActions
    {
        public event Action<InputDevice> DeviceCallback;
        public void OnAccept(InputAction.CallbackContext context)
        {
            DeviceCallback?.Invoke(context.control.device);
        }

        public void OnAnyKey(InputAction.CallbackContext context)
        {
            DeviceCallback?.Invoke(context.control.device);
        }

        public void OnBack(InputAction.CallbackContext context)
        {
            DeviceCallback?.Invoke(context.control.device);
        }

        public void OnInteract(InputAction.CallbackContext context)
        {
            DeviceCallback?.Invoke(context.control.device);
        }

        public void OnInventory(InputAction.CallbackContext context)
        {
            DeviceCallback?.Invoke(context.control.device);
        }

        public void OnTest(InputAction.CallbackContext context)
        {
            DeviceCallback?.Invoke(context.control.device);
        }

        public void OnTouch(InputAction.CallbackContext context)
        {
            DeviceCallback?.Invoke(context.control.device);
        }
    }
    public class GameInputCallback : MAJIKAInput.IGamePlayActions
    {
        public event Action<InputDevice> DeviceCallback;
        public void OnClimb(InputAction.CallbackContext context)
        {
            DeviceCallback?.Invoke(context.control.device);
        }

        public void OnJump(InputAction.CallbackContext context)
        {
            DeviceCallback?.Invoke(context.control.device);
        }

        public void OnMovement(InputAction.CallbackContext context)
        {
            if(context.ReadValue<Vector2>().magnitude > 0)
                DeviceCallback?.Invoke(context.control.device);
        }

        public void OnSkill1(InputAction.CallbackContext context)
        {
            DeviceCallback?.Invoke(context.control.device);
        }

        public void OnSkill2(InputAction.CallbackContext context)
        {
            DeviceCallback?.Invoke(context.control.device);
        }

        public void OnSkill3(InputAction.CallbackContext context)
        {
            DeviceCallback?.Invoke(context.control.device);
        }

        public void OnSkill4(InputAction.CallbackContext context)
        {
            DeviceCallback?.Invoke(context.control.device);
        }
    }

}
