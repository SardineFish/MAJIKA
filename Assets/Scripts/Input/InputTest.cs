using UnityEngine;
using System.Collections;
using UnityEngine.Experimental.Input;

public class InputTest : MonoBehaviour
{
    private void OnEnable()
    {
        //NewInputManager.Instance.Controller.GamePlay.SetCallbacks(this);    
    }

    // Use this for initialization
    void Start()
    {
        InputManager.Instance.Controller.Actions.Test.performed += ctx =>
        {
            GameLog.Log($"{ctx.control.path} performed");
        };
        InputManager.Instance.Controller.Actions.Test.cancelled += ctx
             => GameLog.Log($"{ctx.control.path} cancelled");
        InputManager.Instance.Controller.Actions.Test.started += ctx
            => GameLog.Log($"{ctx.control.path} started");
        
    }

    // Update is called once per frame
    void Update()
    {
    }
}
