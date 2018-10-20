using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

[CreateAssetMenu(fileName ="PlayerJump",menuName ="PlayerState/Jump")]
public class PlayerJump : PlayerState
{
    public PlayerIdle IdleState;
    public PlayerClimb ClimbState;

    public override void OnUpdate(Player player, EntityStateMachine<Player> fsm)
    {
        // Movement
        var movement = InputManager.Instance.GetMovement();
        movement.y = 0;
        player.GetComponent<MovableEntity>().Move(movement);

        // Jump
        if (InputManager.Instance.GetKey(InputManager.Instance.KeyJump))
        {
            if (player.GetComponent<MovableEntity>().Jump())
                fsm.ChangeState(this);
        }

        player.GetComponent<AnimationController>().PlayAnimation(AnimatorController, InputManager.Instance.GetMovement().x);
        if (player.GetComponent<MovableEntity>().OnGround)
            fsm.ChangeState(IdleState);

        // Climb
        if (InputManager.Instance.GetKey(InputManager.Instance.KeyClimb))
        {
            if (player.GetComponent<MovableEntity>().Climb(0))
                fsm.ChangeState(ClimbState);
        }
    }

}