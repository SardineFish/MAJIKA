using UnityEngine;
using System.Collections;

namespace MAJIKA.State
{
    [CreateAssetMenu(fileName = "Idle", menuName = "EntityState/Idle")]
    public class EntityIdle : AnimatedState
    {
        public EntityMove MoveState;
        public EntityJump JumpState;
        public EntitySkill SkillState;
        public EntityClimb ClimbState;
        public EntityAir AirState;

        /*
        public override bool OnEnter(GameEntity entity, EntityState previousState, EntityStateMachine fsm)
        {
            entity.GetComponent<EventBus>().AddEventListenerOnce("Hit", () =>
            {
                fsm.ChangeState(HitState);
            });
            entity.GetComponent<AnimationController>().ChangeAnimation(AnimatorController, (GameSystem.Instance.PlayerInControl.transform.position - entity.transform.position).x);
            return base.OnEnter(entity, previousState, fsm);
        }*/

        public override void OnUpdate(GameEntity entity, EntityStateMachine fsm)
        {
            if (MoveState && fsm.ChangeState(MoveState))
                return;
            if (JumpState && fsm.ChangeState(JumpState))
                return;
            if (SkillState && fsm.ChangeState(SkillState))
                return;
            if (ClimbState && fsm.ChangeState(ClimbState))
                return;
            if (!entity.GetComponent<MovableEntity>().OnGround && fsm.ChangeState(AirState))
                return;
            fsm.GetComponent<AnimationController>().PlayAnimation(AnimatorController, (fsm as EntityController).FaceDirection);
        }
    }

}