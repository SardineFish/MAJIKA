using UnityEngine;
using System.Collections;

namespace State
{
    [CreateAssetMenu(fileName = "Climb", menuName = "EntityState/Climb")]
    public class EntityClimb : GameEntityState
    {
        public EntityAir AirState;
        public EntityJump JumpState;
        public override bool OnEnter(GameEntity entity, EntityState<GameEntity> previousState, EntityStateMachine<GameEntity> fsm)
        {
            if (!(fsm as EntityController).Climbed)
                return false;
            if (!entity.GetComponent<MovableEntity>().Climb((fsm as EntityController).Movement.y))
                return false;
            return base.OnEnter(entity, previousState, fsm);
        }
        public override void OnUpdate(GameEntity entity, EntityStateMachine<GameEntity> fsm)
        {
            if (!entity.GetComponent<MovableEntity>().Climb(InputManager.Instance.GetMovement().y))
                fsm.ChangeState(AirState);

            fsm.ChangeState(JumpState);

        }
    }

}