using UnityEngine;
using System.Collections;

namespace State
{
    [CreateAssetMenu(fileName = "Skill", menuName = "EntityState/Skill")]
    public class EntitySkill : GameEntityState
    {
        public EntityJump JumpState;
        public EntityIdle IdleState;

        public override bool OnEnter(GameEntity entity, EntityState<GameEntity> previousState, EntityStateMachine<GameEntity> fsm)
        {
            var skillIdx = (fsm as EntityController).SkillIndex;
            if (skillIdx < 0 || !entity.GetComponent<SkillController>().Activate(skillIdx, entity.GetComponent<MovableEntity>().FaceDirection))
            {
                return false;
            }
            /*entity.GetComponent<AnimationController>().ChangeAnimation(
                entity.GetComponent<SkillController>().ActiveSkill.AnimatorController,
                entity.GetComponent<MovableEntity>().FaceDirection);*/
            return true;
        }

        public override IEnumerator Begin(GameEntity entity, EntityStateMachine<GameEntity> fsm)
        {

            yield return entity.GetComponent<SkillController>().WaitSkill();
            fsm.ChangeState(IdleState);
        }
    }

}