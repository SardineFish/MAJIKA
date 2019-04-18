using UnityEngine;
using System.Collections;
using UnityEngine.Experimental.Input;

public class NewInputManager : Singleton<NewInputManager>
{
    [Tooltip("Input action assets")]
    public MAJIKAInput Controller;

    public MAJIKAInput.ActionsActions Actions => Controller.Actions;

    public MAJIKAInput.GamePlayActions GamePlay => Controller.GamePlay;
}
