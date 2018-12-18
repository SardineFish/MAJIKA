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
            var movement = InputManager.Instance.GetMovement();
            movement.y = 0;
            return entity.GetComponent<MovableEntity>().Move(movement)
                && !Mathf.Approximately(movement.x, 0);
        }
        public override void OnUpdate(GameEntity entity, EntityStateMachine<GameEntity> fsm)
        {
            // Movement
            var movement = InputManager.Instance.GetMovement();
            movement.y = 0;
            entity.GetComponent<MovableEntity>().Move(movement);

            if (Mathf.Approximately(movement.x, 0))
                fsm.ChangeState(IdleState);
            else
                entity.GetComponent<AnimationController>().ChangeAnimation(AnimatorController, movement.x);

            // Jump
            if (InputManager.Instance.GetAction(InputManager.Instance.JumpAction))
            {
                if (entity.GetComponent<MovableEntity>().Jump())
                    fsm.ChangeState(JumpState);
            }

            // Climb
            if (InputManager.Instance.GetAction(InputManager.Instance.ClimbAction))
            {
                if (entity.GetComponent<MovableEntity>().Climb(0))
                    fsm.ChangeState(ClimbState);
            }

            // Skill
            if (InputManager.Instance.GetSkillIndex() >= 0)
                fsm.ChangeState(SkillState);
        }
    }
}
