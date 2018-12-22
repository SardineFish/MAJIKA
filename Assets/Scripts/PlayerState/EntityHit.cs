using UnityEngine;
using System.Collections;

namespace State
{
    [CreateAssetMenu(fileName = "Hit", menuName = "EntityState/Hit")]
    public class EntityHit : EntityState<GameEntity>
    {
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
                    entity.GetComponent<EntityEffector>().RemoveEffect(blowUp.Effect);
                    while (!fsm.ChangeState(MoveState) && !fsm.ChangeState(JumpState))
                        yield return null;
                    yield break;
                }
                else
                {
                    entity.GetComponent<AnimationController>().PlayAnimation(HitAction, trigger.position.x - entity.transform.position.x);
                    while (!entity.GetComponent<AnimationController>().IsEnd())
                    {
                        yield return null;
                        if (fsm.ChangeState(MoveState) || fsm.ChangeState(JumpState))
                        {
                            Debug.Log("leave");
                            yield break;
                        }
                    }
                }
            }
            fsm.ChangeState(IdleState);
        }

        public override bool OnEnter(GameEntity entity, EntityState<GameEntity> previousState, EntityStateMachine<GameEntity> fsm)
        {
            if (previousState == this)
                return false;
            return base.OnEnter(entity, previousState, fsm);
        }
    }

}