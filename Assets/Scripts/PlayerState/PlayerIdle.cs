using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName ="PlayerIdle",menuName ="PlayerState/Idle")]
public class PlayerIdle : PlayerState
{
    public PlayerJump JumpState;
    public PlayerMove MoveState;
    public PlayerClimb ClimbState;

    public override void OnUpdate(Player player, EntityStateMachine<Player> fsm)
    {
        player.GetComponent<AnimationController>().ChangeAnimation(AnimatorController, 0);
        // Movement
        var movement = InputManager.Instance.GetMovement();
        movement.y = 0;
        player.GetComponent<MovableEntity>().Move(movement);

        if (!Mathf.Approximately(movement.x, 0))
            fsm.ChangeState(MoveState);

        // Jump
        if (InputManager.Instance.GetKey(InputManager.Instance.KeyJump))
        {
            if (player.GetComponent<MovableEntity>().Jump())
                fsm.ChangeState(JumpState);
        }

        // Climb
        if (InputManager.Instance.GetKey(InputManager.Instance.KeyClimb))
        {
            if (player.GetComponent<MovableEntity>().Climb(0))
                fsm.ChangeState(ClimbState);
        }
    }

}
