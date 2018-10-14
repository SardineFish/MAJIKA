using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PlayerJump : PlayerState
{
    public PlayerJump(Player player) : base(player) { }

    public override void Update()
    {
        // Movement
        var movement = InputManager.Instance.GetMovement();
        movement.y = 0;
        Entity.GetComponent<MovableEntity>().Move(movement);

        // Jump
        if (InputManager.Instance.GetKey(InputManager.Instance.KeyJump))
        {
            if (Entity.GetComponent<MovableEntity>().Jump())
                Entity.GetComponent<PlayerController>().ChangeState(new PlayerJump(Entity));
        }

        Entity.GetComponent<AnimationController>().PlayAnimation(Entity.GetComponent<PlayerController>().Jump, InputManager.Instance.GetMovement().x);
        if (Entity.GetComponent<MovableEntity>().OnGround)
            Entity.GetComponent<PlayerController>().ChangeState(new PlayerOnGround(Entity));
    }

}