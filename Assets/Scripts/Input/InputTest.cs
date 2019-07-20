using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem;

public class InputTest : MonoBehaviour
{
    InputAction action;
    private void OnEnable()
    {
        //NewInputManager.Instance.Controller.GamePlay.SetCallbacks(this);    
    }

    // Use this for initialization
    void Start()
    {
        action = new InputAction(binding: "/*/<button>");
        action.Enable();
        action.performed += (ctx) =>
        {
        };
        /*InputManager.Instance.GamePlay.Jump.performed += ctx =>
        {
            GetComponent<SpriteRenderer>().color = Utility.RandomColor();
        };*/
        /*InputManager.Instance.Actions.Test.performed += ctx =>
        {
            Debug.Log($"performed {ctx.control.path} {ctx.phase}");
        };
        InputManager.Instance.Actions.Test.started += ctx =>
        {
            Debug.Log($"started {ctx.control.path} {ctx.phase}");
        };
        InputManager.Instance.Actions.Test.cancelled += ctx =>
         {
             Debug.Log($"cancelled {ctx.control.path} {ctx.phase}");
         };*/
        
    }

    // Update is called once per frame
    void Update()
    {
        //Touchscreen.current.activeTouches.ForEach(touch => Debug.Log(touch.position));
    }
}
