using UnityEngine;
using System.Collections;
using UnityEngine.Experimental.Input;
using System.Linq;

public class InputManager : Singleton<InputManager>
{
    private void OnEnable()
    {
        Controller.Enable();
    }
    [Tooltip("Input action assets")]
    public MAJIKAInput Controller;

    public MAJIKAInput.ActionsActions Actions => Controller.Actions;

    public MAJIKAInput.GamePlayActions GamePlay => Controller.GamePlay;

    public bool GetTouch()
    {
        return Input.touches.Any(touch => touch.phase == TouchPhase.Began);
    }
}
