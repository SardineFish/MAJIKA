using UnityEngine;
using System.Collections;

namespace State
{
    [CreateAssetMenu(fileName = "Move", menuName = "EntityState/Move")]
    public class EntityMove : AnimatedState
    {
        public AudioClip FootStep;
        public float Delay = 0;
        public float Duration = 0.5f;
        public float Volumn = 1;
        public EntityIdle IdleState;
        public EntityJump JumpState;
        public EntityClimb ClimbState;
        public EntitySkill SkillState;
        public EntityAir AirState;
        public override bool OnEnter(GameEntity entity, EntityState previousState, EntityStateMachine fsm)
        {
            var movement = entity.GetComponent<EntityController>().Movement;
            movement.y = 0;
            if (!Mathf.Approximately(movement.x, 0) && entity.GetComponent<MovableEntity>().Move(movement))
                return base.OnEnter(entity, previousState, fsm);
            return false;
        }
        public override void OnUpdate(GameEntity entity, EntityStateMachine fsm)
        {
            // Movement
            var movement = entity.GetComponent<EntityController>().Movement;
            movement.y = 0;
            entity.GetComponent<MovableEntity>().Move(movement);

            if (Mathf.Approximately(movement.x, 0))
                fsm.ChangeState(IdleState);
            else
                entity.GetComponent<AnimationController>().ChangeAnimation(AnimatorController, movement.x);

            if (!entity.GetComponent<MovableEntity>().OnGround)
                fsm.ChangeState(AirState);

            if (JumpState)
                fsm.ChangeState(JumpState);

            if (ClimbState)
                fsm.ChangeState(ClimbState);

            if (SkillState)
                fsm.ChangeState(SkillState);
            
        }
        public override IEnumerator Begin(GameEntity entity, EntityStateMachine fsm)
        {
            yield return new WaitForSeconds(Delay);
            while (true)
            {
                entity.GetComponent<AudioController>().PlayEffect(FootStep, 0.8f*Volumn);
                yield return new WaitForSeconds(Duration);
                entity.GetComponent<AudioController>().PlayEffect(FootStep, 0.6f*Volumn);
                yield return new WaitForSeconds(Duration);
                entity.GetComponent<AudioController>().PlayEffect(FootStep, 1*Volumn);
                yield return new WaitForSeconds(Duration);
                entity.GetComponent<AudioController>().PlayEffect(FootStep, 0.4f*Volumn);
                yield return new WaitForSeconds(Duration);
            }
        }
    }
}
