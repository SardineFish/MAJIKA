using UnityEngine;
using System.Collections;

namespace State
{
    [CreateAssetMenu(fileName = "Climb", menuName = "EntityState/Climb")]
    public class EntityClimb : GameEntityState
    {
        public EntityAir AirState;
        public override bool OnEnter(GameEntity entity, EntityState<GameEntity> previousState, EntityStateMachine<GameEntity> fsm)
        {
            if (Mathf.Approximately(0, (fsm as EntityController).ClimbSpeed) || !entity.GetComponent<MovableEntity>().Climb(InputManager.Instance.GetMovement().y))
                return false;
            return base.OnEnter(entity, previousState, fsm);
        }
        public override void OnUpdate(GameEntity entity, EntityStateMachine<GameEntity> fsm)
        {
            if (!entity.GetComponent<MovableEntity>().Climb(InputManager.Instance.GetMovement().y))
                fsm.ChangeState(AirState);


        }
    }

}