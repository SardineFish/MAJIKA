using UnityEngine;
using System.Collections;
using UnityEngine.Experimental.Input;

public class InputTest : MonoBehaviour, IGamePlayActions
{
    private void OnEnable()
    {
        //NewInputManager.Instance.Controller.GamePlay.SetCallbacks(this);    
    }

    public MAJIKAInput InputAsset;

    public void OnAccept(InputAction.CallbackContext context)
    {
        Debug.Log("Accept");
    }

    public void OnClimb(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        Debug.Log("Jump");
    }

    public void OnMovement(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnSkill1(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnSkill2(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnSkill3(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnSkill4(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    // Use this for initialization
    void Start()
    {
        InputAsset.Enable();
        InputAsset.GamePlay.Jump.performed += OnJump;
        //InputAsset.GamePlay.SetCallbacks(this);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(InputAsset.GamePlay);
    }
}
