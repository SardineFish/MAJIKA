using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem;
using System.Collections.Generic;

public class EntityInputPlugin : ControllerPlugin, MAJIKAInput.IGamePlayActions
{
    private MAJIKAInput inputAsset;
    /*/
    bool climb = false;
    bool jump = false;
    Vector2 movement = Vector2.zero;
    int skill = -1;*/
    List<int> activeSkills = new List<int>();

    public override Vector2 Movement => inputAsset.GamePlay.Movement.ReadValue<Vector2>();

    public override int SkillIndex => activeSkills.Count > 0 ? activeSkills[activeSkills.Count - 1] : -1;

    public override bool Jumped => inputAsset.GamePlay.Jump.ReadValue<float>() > 0;

    public override bool Climbed => inputAsset.GamePlay.Climb.ReadValue<float>() > 0;

    public override float FaceDirection => inputAsset.GamePlay.Movement.ReadValue<Vector2>().x;

    public override GameEntity SkillTarget => null;

    private void OnEnable()
    {
        inputAsset = new MAJIKAInput();
        inputAsset.GamePlay.SetCallbacks(this);
        inputAsset.Enable();
    }

    public void OnClimb(InputAction.CallbackContext context)
    {
    }

    public void OnJump(InputAction.CallbackContext context)
    {
    }

    public void OnMovement(InputAction.CallbackContext context)
    {
    }

    void handleSkill(int idx, InputAction.CallbackContext context)
    {
        if ((context.started || context.performed) && !activeSkills.Contains(idx))
            activeSkills.Add(idx);
        else if (context.canceled)
            activeSkills.Remove(idx);
    }

    public void OnSkill1(InputAction.CallbackContext context)
        => handleSkill(0, context);

    public void OnSkill2(InputAction.CallbackContext context)
        => handleSkill(1, context);

    public void OnSkill3(InputAction.CallbackContext context)
        => handleSkill(2, context);

    public void OnSkill4(InputAction.CallbackContext context)
        => handleSkill(3, context);

    public override void OnUpdate(EntityController controller)
    {
        Debug.Log(inputAsset.GamePlay.Jump.ReadValue<float>());
        /*
        controller.Movement = inputAsset.GamePlay.Movement.ReadValue<Vector2>();// movement;
        controller.Jumped = inputAsset.GamePlay.Jump.ReadValue<float>() > 0;// jump;
        controller.Climbed = inputAsset.GamePlay.Climb.ReadValue<float>() > 0;// climb;
        controller.SkillIndex = skill;
        controller.FaceDirection = controller.Movement.x;

        movement = Vector2.zero;
        jump = false;
        climb = false;
        skill = -1;*/
    }
}
