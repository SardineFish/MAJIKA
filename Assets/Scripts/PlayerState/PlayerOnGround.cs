using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SardineFish.Unity.FSM;
using UnityEngine;

public class PlayerOnGround : PlayerState
{
    public PlayerOnGround(Player player) : base(player) { }

    public override void Update()
    {
        // Movement
        var movement = InputManager.Instance.GetMovement();
        movement.y = 0;
        Entity.GetComponent<MovableEntity>().Move(movement);

        if (Mathf.Approximately(movement.x, 0))
            Entity.GetComponent<AnimationController>().ChangeAnimation(Entity.GetComponent<PlayerController>().Idle, movement.x);
        else
            Entity.GetComponent<AnimationController>().ChangeAnimation(Entity.GetComponent<PlayerController>().Walk, movement.x);

        // Jump
        if (InputManager.Instance.GetKey(InputManager.Instance.KeyJump))
        {
            if (Entity.GetComponent<MovableEntity>().Jump())
                Entity.GetComponent<PlayerController>().ChangeState(new PlayerJump(Entity));
        }
    }

}