using UnityEngine;
using System.Collections;

namespace State
{
    [CreateAssetMenu(fileName = "Hit", menuName = "EntityState/Hit")]
    public class EntityHit : EntityState<GameEntity>
    {
        public float BlowUpSleepTime = 0.5f;
        public RuntimeAnimatorController HitAction;
        public RuntimeAnimatorController BlowUpAction;
        public EntityIdle IdleState;
        public EntityMove MoveState;
        public EntityJump JumpState;

        public override IEnumerator Begin(GameEntity entity, EntityStateMachine<GameEntity> fsm)
        {
            var trigger = entity.GetComponent<EntityEffector>()?.GetEffect<Damage>()?.GetTrigger<ImpactData>();
            var blowUp = entity.GetComponent<EntityEffector>()?.GetEffect<BlowUp>();
            if(trigger!=null)
            {
                if (blowUp != null)
                {
                    var locker = (fsm as EntityController).Lock(this);
                    // Debug.Log($"locked {(fsm as EntityController).Locker.Locked}");
                    entity.GetComponent<SkillController>().Abort();
                    var movable = entity.GetComponent<MovableEntity>();
                    var v = (blowUp.Effect as BlowUp).Blow;
                    v.x *= MathUtility.SignInt(blowUp.GetTrigger<ImpactData>().position.x - entity.transform.position.x);
                    entity.GetComponent<MovableEntity>().Frozen = true;
                    entity.GetComponent<MovableEntity>().SetVelocity(v);
                    entity.GetComponent<AnimationController>().PlayAnimation(BlowUpAction, trigger.position.x - entity.transform.position.x);
                    yield return null;
                    while (!movable.OnGround)
                        yield return null;
                    movable.Frozen = false;
                    entity.GetComponent<Animator>().SetTrigger("end");
                    yield return new WaitForSeconds(BlowUpSleepTime);
                    entity.GetComponent<EntityEffector>().RemoveEffect(blowUp.Effect);
                    (fsm as EntityController).UnLock(locker);
                    while (!fsm.ChangeState(MoveState) && !fsm.ChangeState(JumpState))
                        yield return null;
                    // Debug.Log($"unlocked {(fsm as EntityController).Locker.Locked}");
                    yield break;
                }
                else
                {
                    entity.GetComponent<AnimationController>().PlayAnimation(HitAction, trigger.position.x - entity.transform.position.x);
                    while (!entity.GetComponent<AnimationController>().IsEnd())
                    {
                        yield return null;
                        if (fsm.ChangeState(JumpState) || fsm.ChangeState(MoveState))
                        {
                            yield break;
                        }
                    }
                }
            }
            fsm.ChangeState(IdleState);
        }

        public override bool OnEnter(GameEntity entity, EntityState<GameEntity> previousState, EntityStateMachine<GameEntity> fsm)
        {
            return base.OnEnter(entity, previousState, fsm);
        }

        public override bool OnExit(GameEntity entity, EntityState<GameEntity> nextState, EntityStateMachine<GameEntity> fsm)
        {
            if (nextState is EntityHit)
                return false;
            if (nextState is EntitySkill)
                return false;
            return true;
        }
    }

}