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
        if (InputManager.Instance.GetKey(InputManager.Instance.KeyJump))
        {
            if (player.GetComponent<MovableEntity>().Jump())
                fsm.ChangeState(JumpState);
        }
    }

}