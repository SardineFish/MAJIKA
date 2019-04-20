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
        InputManager.Instance.GamePlay.Jump.performed += ctx =>
        {
            GetComponent<SpriteRenderer>().color = Utility.RandomColor();
        };
        InputManager.Instance.GamePlay.Jump.cancelled += ctx =>
        {
            Debug.Log("can");
        };
        
    }

    // Update is called once per frame
    void Update()
    {
    }
}
