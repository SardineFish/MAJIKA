using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName ="PlayerClimb",menuName ="PlayerState/Climb")]
public class PlayerClimb : PlayerState
{
    public PlayerJump JumpState;

    public override void OnUpdate(Player player, EntityStateMachine<Player> fsm)
    {
        player.GetComponent<MovableEntity>().Climb(InputManager.Instance.GetMovement().y);
        player.GetComponent<AnimationController>().ChangeAnimation(AnimatorController, 0);

        // Jump
        if (InputManager.Instance.GetAction(InputManager.Instance.JumpAction))
        {
            if (player.GetComponent<MovableEntity>().Jump())
                fsm.ChangeState(JumpState);
        }
    }
}
