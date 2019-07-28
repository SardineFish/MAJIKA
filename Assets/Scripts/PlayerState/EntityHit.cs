using UnityEngine;
using System.Collections;

namespace MAJIKA.State
{
    [CreateAssetMenu(fileName = "Hit", menuName = "EntityState/Hit")]
    public class EntityHit : EntityState
    {
        public float BlowUpSleepTime = 0.5f;
        public RuntimeAnimatorController HitAction;
        public RuntimeAnimatorController BlowUpAction;
        public EntityIdle IdleState;
        public EntityMove MoveState;
        public EntityJump JumpState;

        public override IEnumerator Begin(GameEntity entity, EntityStateMachine fsm)
        {
            var trigger = entity.GetComponent<EntityEffector>()?.GetEffect<Damage>()?.GetTrigger<ImpactData>();
            var blowUp = entity.GetComponent<EntityEffector>()?.GetEffect<BlowUp>();
            var effector = entity.GetComponent<EntityEffector>();
            if(trigger!=null)
            {
                if (blowUp != null)
                {
                    var locker = (fsm as EntityController).Lock(this);
                    // Debug.Log($"locked {(fsm as EntityController).Locker.Locked}");
                    entity.GetComponent<SkillController>().Abort();
                    var movable = entity.GetComponent<MovableEntity>();
                    var v = (blowUp.Effect as BlowUp).Blow;
                    v.x *= MathUtility.SignInt(blowUp.GetTrigger<ImpactData>().Position.x - entity.transform.position.x);
                    entity.GetComponent<MovableEntity>().Frozen = true;
                    entity.GetComponent<MovableEntity>().SetVelocity(v);
                    entity.GetComponent<AnimationController>().PlayAnimation(BlowUpAction, trigger.Position.x - entity.transform.position.x);
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
                    var interrupt = effector.GetEffect<Interruption>();
                    if(interrupt != null && entity.GetComponent<SkillController>().Interrupt(Mathf.RoundToInt(interrupt.Strength)))
                    {
                        entity.GetComponent<AnimationController>().PlayAnimation(HitAction, trigger.Position.x - entity.transform.position.x);
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
            }
            fsm.ChangeState(IdleState);
        }

        public override bool OnEnter(GameEntity entity, EntityState previousState, EntityStateMachine fsm)
        {
            var effector = entity.GetComponent<EntityEffector>();
            var trigger = effector.GetEffect<Damage>()?.GetTrigger<ImpactData>()
                ?? effector.GetEffect<BlowUp>()?.GetTrigger<ImpactData>()
                ?? effector.GetEffect<Interruption>()?.GetTrigger<ImpactData>();
            var blowUp = effector.GetEffect<BlowUp>();
            var interrupt = effector.GetEffect<Interruption>();
            if (trigger == null)
                return false;
            if (blowUp != null)
                return true;
            if (fsm.State is EntityMove)
                return false;
            if (interrupt is null && fsm.State is EntitySkill)
                return false;
            if (interrupt != null && !entity.GetComponent<SkillController>().Interrupt(Mathf.RoundToInt(interrupt.Strength)))
                return false;
            return true;
        }

        public override bool OnExit(GameEntity entity, EntityState nextState, EntityStateMachine fsm)
        {
            if (nextState is EntityHit)
                return false;
            if (nextState is EntitySkill)
                return false;
            return true;
        }
    }

}