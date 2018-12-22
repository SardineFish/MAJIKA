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
                    yield return entity.GetComponent<AnimationController>().WaitAnimation(BlowUpAction, trigger.position.x - entity.transform.position.x);
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

        /*

        public override bool OnEnter(GameEntity entity, EntityState<GameEntity> previousState, EntityStateMachine<GameEntity> fsm)
        {
            //entity.GetComponent<EntityEffector>().GetEffect<>
            entity.GetComponent<AnimationController>().ChangeAnimation(this.AnimatorController, (GameSystem.Instance.PlayerInControl.transform.position - entity.transform.position).x);
            //entity.GetComponent<AnimationController>().ChangeAnimation(AnimatorController, (GameSystem.Instance.PlayerInControl.transform.position - entity.transform.position).x);
            /*Utility.WaitForSecond(entity, () =>
            {
                fsm.ChangeState(IdleState);
            }, 0.5f); /
            return base.OnEnter(entity, previousState, fsm);
        }

        public override void OnUpdate(GameEntity entity, EntityStateMachine<GameEntity> fsm)
        {
            base.OnUpdate(entity, fsm);
        }*/
    }

}