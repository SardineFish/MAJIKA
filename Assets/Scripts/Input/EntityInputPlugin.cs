using UnityEngine;
using System.Collections;
using UnityEngine.Experimental.Input;

public class EntityInputPlugin : ControllerPlugin, IGamePlayActions
{
    private MAJIKAInput inputAsset;
    bool climb = false;
    bool jump = false;
    Vector2 movement = Vector2.zero;
    int skill = -1;

    private void OnEnable()
    {
        inputAsset = InputManager.Instance.Controller.Clone() as MAJIKAInput;
        inputAsset.MakePrivateCopyOfActions();
        inputAsset.GamePlay.SetCallbacks(this);
        inputAsset.Enable();
    }

    public void OnClimb(InputAction.CallbackContext context)
    {
        climb = true;
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        jump = true;
    }

    public void OnMovement(InputAction.CallbackContext context)
    {
        movement = context.ReadValue<Vector2>();
    }

    public void OnSkill1(InputAction.CallbackContext context)
    {
        skill = 0;
    }

    public void OnSkill2(InputAction.CallbackContext context)
    {
        skill = 1;
    }

    public void OnSkill3(InputAction.CallbackContext context)
    {
        skill = 2;
    }

    public void OnSkill4(InputAction.CallbackContext context)
    {
        skill = 3;
    }

    public override void OnUpdate(EntityController controller)
    {
        controller.Movement = movement;
        controller.Jumped = jump;
        controller.Climbed = climb;
        controller.SkillIndex = skill;

        movement = Vector2.zero;
        jump = false;
        climb = false;
        skill = -1;
    }
}
