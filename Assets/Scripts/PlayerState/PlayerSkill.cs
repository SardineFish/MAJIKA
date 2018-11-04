using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName ="PlayerSkill", menuName ="PlayerState/Skill")]
public class PlayerSkill : EntityState<Player>
{
    public PlayerJump JumpState;
    public override bool OnEnter(Player player, EntityState<Player> previousState, EntityStateMachine<Player> fsm)
    {
        var skillIdx = InputManager.Instance.GetSkillIndex();
        if (skillIdx < 0)
            return false;

        /*player.GetComponent<EventBus>().AddEventListenerOnce(SkillController.EventSkillEnd, () =>
        {
            fsm.ChangeState(JumpState);
        });*/
        player.GetComponent<SkillController>().Activate(skillIdx);
        return true;
    }
    public override void OnUpdate(Player player, EntityStateMachine<Player> fsm)
    {
        var activedSkill = player.GetComponent<SkillController>().ActiveSkill;
        if (activedSkill == null)
        {
            fsm.ChangeState(JumpState);
            return;
        }

        player.GetComponent<AnimationController>().ChangeAnimation(activedSkill.AnimatorController, player.GetComponent<MovableEntity>().FaceDirection);

        // Lock
        if (player.GetComponent<SkillController>().IsLocked())
            return;

        // Movement
        var movement = InputManager.Instance.GetMovement();
        movement.y = 0;
        player.GetComponent<MovableEntity>().Move(movement);

        // Jump
        if (InputManager.Instance.GetAction(InputManager.Instance.JumpAction))
        {
            if (player.GetComponent<MovableEntity>().Jump())
                fsm.ChangeState(JumpState);
        }
    }
}
