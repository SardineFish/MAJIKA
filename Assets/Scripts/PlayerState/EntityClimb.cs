using UnityEngine;
using System.Collections;

namespace MAJIKA.State
{
    [CreateAssetMenu(fileName = "Climb", menuName = "EntityState/Climb")]
    public class EntityClimb : AnimatedState
    {
        public EntityAir AirState;
        public EntityJump JumpState;
        public override bool OnEnter(GameEntity entity, EntityState previousState, EntityStateMachine fsm)
        {
            if (!(fsm as EntityController).Climbed)
                return false;
            if (!entity.GetComponent<MovableEntity>().Climb((fsm as EntityController).Movement.y))
                return false;
            return base.OnEnter(entity, previousState, fsm);
        }
        public override void OnUpdate(GameEntity entity, EntityStateMachine fsm)
        {
            if (!entity.GetComponent<MovableEntity>().Climb((fsm as EntityController).Movement.y))
                fsm.ChangeState(AirState);

            fsm.ChangeState(JumpState);

        }
    }

}