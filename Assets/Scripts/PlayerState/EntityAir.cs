using UnityEngine;
using System.Collections;

namespace MAJIKA.State
{
    [CreateAssetMenu(fileName = "Air", menuName = "EntityState/Air")]
    public class EntityAir : AnimatedState
    {
        public EntityIdle IdleState;
        public EntityClimb ClimbState;

        public override void OnUpdate(GameEntity entity, EntityStateMachine fsm)
        {
            var movable = entity.GetComponent<MovableEntity>();
            var movement = (fsm as EntityController).Movement;
            movement.y = 0;
            entity.GetComponent<AnimationController>().PlayAnimation(AnimatorController, movement.x);
            movable.Move(movement);
            if (movable.velocity.y < 0)
                movable.GravityScale = 1.4f;
            else
                movable.GravityScale = 1;
            if (movable.OnGround)
            {
                movable.GravityScale = 1f;
                fsm.ChangeState(IdleState);
            }
            if (ClimbState)
                fsm.ChangeState(ClimbState);
        }
    }
}
