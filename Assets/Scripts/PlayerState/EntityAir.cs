using UnityEngine;
using System.Collections;

namespace State
{
    [CreateAssetMenu(fileName = "Air", menuName = "EntityState/Air")]
    public class EntityAir : GameEntityState
    {
        public EntityIdle IdleState;
        public EntityClimb ClimbState;

        public override void OnUpdate(GameEntity entity, EntityStateMachine<GameEntity> fsm)
        {
            var movement = (fsm as EntityController).Movement;
            movement.y = 0;
            entity.GetComponent<AnimationController>().PlayAnimation(AnimatorController, movement.x);
            entity.GetComponent<MovableEntity>().Move(movement);
            if (entity.GetComponent<MovableEntity>().OnGround)
                fsm.ChangeState(IdleState);
            if (ClimbState)
                fsm.ChangeState(ClimbState);
        }
    }
}
