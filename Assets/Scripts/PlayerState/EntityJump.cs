using UnityEngine;
using System.Collections;

namespace State
{
    [CreateAssetMenu(fileName = "Jump", menuName = "EntityState/Jump")]
    public class EntityJump : GameEntityState
    {
        public EntityAir AirState;
        public EntityMove MoveState;
        public EntityIdle IdleState;
        public EntityClimb ClimbState;

        public override bool OnEnter(GameEntity entity, EntityState<GameEntity> previousState, EntityStateMachine<GameEntity> fsm)
        {
            if((fsm as EntityController).Jumped && entity.GetComponent<MovableEntity>().Jump())
            {
                base.OnEnter(entity, previousState, fsm);
                fsm.ChangeState(AirState);
            }
            return false;
        }

        public override void OnUpdate(GameEntity entity, EntityStateMachine<GameEntity> fsm)
        {
            if (MoveState)
                fsm.ChangeState(MoveState);
            if (ClimbState)
                fsm.ChangeState(ClimbState);
        }
    }

}