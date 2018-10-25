using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SardineFish.Unity.FSM;
using UnityEngine;

[CreateAssetMenu(fileName ="PlayerMove",menuName ="PlayerState/Move")]
public class PlayerMove : PlayerState
{
    public PlayerIdle IdleState;
    public PlayerJump JumpState;
    public PlayerClimb ClimbState;

    public override void OnUpdate(Player player, EntityStateMachine<Player> fsm)
    {
        // Movement
        var movement = InputManager.Instance.GetMovement();
        movement.y = 0;
        player.GetComponent<MovableEntity>().Move(movement);

        if (Mathf.Approximately(movement.x, 0))
            fsm.ChangeState(IdleState);
        else
            player.GetComponent<AnimationController>().ChangeAnimation(AnimatorController, movement.x);

        // Jump
        if (InputManager.Instance.GetAction(InputManager.Instance.JumpAction))
        {
            if (player.GetComponent<MovableEntity>().Jump())
                fsm.ChangeState(JumpState);
        }

        // Climb
        if(InputManager.Instance.GetAction(InputManager.Instance.ClimbAction))
        {
            if (player.GetComponent<MovableEntity>().Climb(0))
                fsm.ChangeState(ClimbState);
        }
    }

}