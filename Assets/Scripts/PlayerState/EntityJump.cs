using UnityEngine;
using System.Collections;

namespace State
{
    [CreateAssetMenu(fileName = "Jump", menuName = "EntityState/Jump")]
    public class EntityJump : AnimatedState
    {
        public EntityAir AirState;
        public EntityMove MoveState;
        public EntityIdle IdleState;
        public EntityClimb ClimbState;

        public override bool OnEnter(GameEntity entity, EntityState previousState, EntityStateMachine fsm)
        {
            if((fsm as EntityController).Jumped && entity.GetComponent<MovableEntity>().Jump())
            {
                base.OnEnter(entity, previousState, fsm);
                fsm.ChangeState(AirState);
            }
            return false;
        }

        public override void OnUpdate(GameEntity entity, EntityStateMachine fsm)
        {
            if (MoveState)
                fsm.ChangeState(MoveState);
            if (ClimbState)
                fsm.ChangeState(ClimbState);
        }
    }

}