using UnityEngine;
using System.Collections;
using State;

namespace State
{
    [CreateAssetMenu(fileName = "Idle", menuName = "EntityState/Idle")]
    public class EntityIdle : GameEntityState
    {
        public EntityMove MoveState;
        public EntityJump JumpState;
        public EntitySkill SkillState;
        public EntityClimb ClimbState;

        /*
        public override bool OnEnter(GameEntity entity, EntityState<GameEntity> previousState, EntityStateMachine<GameEntity> fsm)
        {
            entity.GetComponent<EventBus>().AddEventListenerOnce("Hit", () =>
            {
                fsm.ChangeState(HitState);
            });
            entity.GetComponent<AnimationController>().ChangeAnimation(AnimatorController, (GameSystem.Instance.PlayerInControl.transform.position - entity.transform.position).x);
            return base.OnEnter(entity, previousState, fsm);
        }*/

        public override void OnUpdate(GameEntity entity, EntityStateMachine<GameEntity> fsm)
        {
            if (MoveState)
                fsm.ChangeState(MoveState);
            if (JumpState)
                fsm.ChangeState(JumpState);
            if (SkillState)
                fsm.ChangeState(SkillState);
            if (ClimbState)
                fsm.ChangeState(ClimbState);
        }
    }

}