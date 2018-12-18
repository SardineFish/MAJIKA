using UnityEngine;
using System.Collections;

namespace State
{
    [CreateAssetMenu(fileName = "Skill", menuName = "EntityState/Skill")]
    public class EntitySkill : GameEntityState
    {
        public EntityJump JumpState;
        public EntityIdle IdleState;

        public override IEnumerator Begin(GameEntity entity, EntityStateMachine<GameEntity> fsm)
        {
            var skillIdx = InputManager.Instance.GetSkillIndex();
            if (skillIdx < 0)
                yield break;
            if (!entity.GetComponent<SkillController>().Activate(skillIdx))
                yield break;

            entity.GetComponent<AnimationController>().ChangeAnimation(
                entity.GetComponent<SkillController>().ActiveSkill.AnimatorController,
                entity.GetComponent<MovableEntity>().FaceDirection);

            yield return entity.GetComponent<SkillController>().WaitSkill();
            fsm.ChangeState(IdleState);
        }
    }

}