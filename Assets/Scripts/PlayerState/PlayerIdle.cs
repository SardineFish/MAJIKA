using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName ="PlayerIdle",menuName ="PlayerState/Idle")]
public class PlayerIdle : PlayerState
{
    public PlayerJump JumpState;
    public PlayerMove MoveState;

    public override void OnUpdate(Player player, EntityStateMachine<Player> fsm)
    {
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
    }

}
