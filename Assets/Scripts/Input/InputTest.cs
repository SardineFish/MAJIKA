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
        Debug.Log(Gamepad.current.buttonNorth.valueType);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
