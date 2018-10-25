using UnityEngine;
using System.Collections;

public class PlayerSkill : EntityState<Player>
{
    public PlayerJump JumpState;
    public override bool OnEnter(Player player, EntityState<Player> previousState, EntityStateMachine<Player> fsm)
    {
        /*if (!player.GetComponent<SkillController>().Activate(InputManager.Instance.GetSkillIndex()))
            return false;*/

        player.GetComponent<EventBus>().AddEventListenerOnce(SkillController.EventSkillEnd, () =>
        {
            fsm.ChangeState(JumpState);
        });
        return true;
    }
    public override void OnUpdate(Player player, EntityStateMachine<Player> fsm)
    {
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
