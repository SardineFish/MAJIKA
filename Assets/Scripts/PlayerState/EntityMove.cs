using UnityEngine;
using System.Collections;

namespace State
{
    [CreateAssetMenu(fileName = "Move", menuName = "EntityState/Move")]
    public class EntityMove : GameEntityState
    {
        public EntityIdle IdleState;
        public EntityJump JumpState;
        public EntityClimb ClimbState;
        public EntitySkill SkillState;
        public override bool OnEnter(GameEntity entity, EntityState<GameEntity> previousState, EntityStateMachine<GameEntity> fsm)
        {
            var movement = entity.GetComponent<EntityController>().Movement;
            movement.y = 0;
            if (!Mathf.Approximately(movement.x, 0) && entity.GetComponent<MovableEntity>().Move(movement))
                return base.OnEnter(entity, previousState, fsm);
            return false;
        }
        public override void OnUpdate(GameEntity entity, EntityStateMachine<GameEntity> fsm)
        {
            // Movement
            var movement = entity.GetComponent<EntityController>().Movement;
            movement.y = 0;
            entity.GetComponent<MovableEntity>().Move(movement);

            if (Mathf.Approximately(movement.x, 0))
                fsm.ChangeState(IdleState);
            else
                entity.GetComponent<AnimationController>().ChangeAnimation(AnimatorController, movement.x);

            if (JumpState)
                fsm.ChangeState(JumpState);

            if (ClimbState)
                fsm.ChangeState(ClimbState);

            if (SkillState)
                fsm.ChangeState(SkillState);
            
        }
    }
}
