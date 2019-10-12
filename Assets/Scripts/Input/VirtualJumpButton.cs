using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem;

public class VirtualJumpButton : VirtualButton
{
    [UnityEngine.InputSystem.Layouts.InputControl(layout ="Button")]
    public string ClimbControlPath;
    [UnityEngine.InputSystem.Layouts.InputControl(layout = "Button")]
    public string JumpControlPath;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameSystem.Instance.PlayerInControl?.GetComponent<EntityController>().State is MAJIKA.State.EntityAir)
        {
            this.controlPath = ClimbControlPath;
        }
        else
            this.controlPath = JumpControlPath;
    }
}
