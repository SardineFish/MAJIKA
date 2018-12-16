using UnityEngine;
using System.Collections;

namespace State
{
    [CreateAssetMenu(fileName = "Skill", menuName = "EntityState/Skill")]
    public class EntitySkill : GameEntityState
    {
        public EntityJump JumpState;
        public override bool OnEnter(GameEntity entity, EntityState<GameEntity> previousState, EntityStateMachine<GameEntity> fsm)
        {
            var skillIdx = InputManager.Instance.GetSkillIndex();
            if (skillIdx < 0)
                return false;

            /*player.GetComponent<EventBus>().AddEventListenerOnce(SkillController.EventSkillEnd, () =>
            {
                fsm.ChangeState(JumpState);
            });*/
            entity.GetComponent<SkillController>().Activate(skillIdx);
            return true;
        }
        public override void OnUpdate(GameEntity entity, EntityStateMachine<GameEntity> fsm)
        {
            var activedSkill = entity.GetComponent<SkillController>().ActiveSkill;
            if (activedSkill == null)
            {
                fsm.ChangeState(JumpState);
                return;
            }

            entity.GetComponent<AnimationController>().ChangeAnimation(activedSkill.AnimatorController, entity.GetComponent<MovableEntity>().FaceDirection);

            // Lock
            if (entity.GetComponent<SkillController>().IsLocked())
                return;

            // Movement
            var movement = InputManager.Instance.GetMovement();
            movement.y = 0;
            entity.GetComponent<MovableEntity>().Move(movement);

            // Jump
            if (InputManager.Instance.GetAction(InputManager.Instance.JumpAction))
            {
                if (entity.GetComponent<MovableEntity>().Jump())
                    fsm.ChangeState(JumpState);
            }
        }
    }

}