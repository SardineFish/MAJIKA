using UnityEngine;
using System.Collections;

namespace MAJIKA.State
{
    [CreateAssetMenu(fileName = "Skill", menuName = "EntityState/Skill")]
    public class EntitySkill : AnimatedState
    {
        public EntityJump JumpState;
        public EntityIdle IdleState;

        public override bool OnEnter(GameEntity entity, EntityState previousState, EntityStateMachine fsm)
        {
            var skillIdx = (fsm as EntityController).SkillIndex;
            var skillTarget = (fsm as EntityController).SkillTarget;

            if(skillTarget && skillIdx >=0 && entity.GetComponent<SkillController>().Activate(skillIdx, skillTarget))
            {
                entity.GetComponent<AudioController>().PlayAudio(null);
                return true;
            }
            else if (skillIdx >= 0 && entity.GetComponent<SkillController>().Activate(skillIdx, entity.GetComponent<EntityController>().FaceDirection))
            {
                entity.GetComponent<AudioController>().PlayAudio(null);
                return true;
            }
            return false;
        }

        public override IEnumerator Begin(GameEntity entity, EntityStateMachine fsm)
        {
            yield return entity.GetComponent<SkillController>().WaitSkill();
            fsm.ChangeState(IdleState);
        }
    }

}