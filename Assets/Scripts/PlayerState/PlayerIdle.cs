using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName ="PlayerIdle",menuName ="PlayerState/Idle")]
public class PlayerIdle : PlayerControllerState
{
    public PlayerJump JumpState;
    public PlayerMove MoveState;
    public PlayerClimb ClimbState;
    public PlayerSkill SkillState;

    public override void OnUpdate(Player player, EntityStateMachine<Player> fsm)
    {
        player.GetComponent<AnimationController>().ChangeAnimation(AnimatorController, 0);
        // Movement
        var movement = InputManager.Instance.GetMovement();
        movement.y = 0;
        player.GetComponent<MovableEntity>().Move(movement);

        if (!Mathf.Approximately(movement.x, 0))
            fsm.ChangeState(MoveState);

        InputManager.Instance.GetAction(InputManager.Instance.JumpAction);
        // Jump
        if (InputManager.Instance.GetAction(InputManager.Instance.JumpAction))
        {
            if (player.GetComponent<MovableEntity>().Jump())
                fsm.ChangeState(JumpState);
        }

        // Climb
        if (InputManager.Instance.GetAction(InputManager.Instance.ClimbAction))
        {
            if (player.GetComponent<MovableEntity>().Climb(0))
                fsm.ChangeState(ClimbState);
        }

        // Skill
        if (InputManager.Instance.GetSkillIndex() >= 0)
            fsm.ChangeState(SkillState);
    }

}
