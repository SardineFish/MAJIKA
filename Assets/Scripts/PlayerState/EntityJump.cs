using UnityEngine;
using System.Collections;

namespace State
{
    [CreateAssetMenu(fileName = "Jump", menuName = "EntityState/Jump")]
    public class EntityJump : GameEntityState
    {
        public EntityMove MoveState;
        public EntityIdle IdleState;

        public override bool OnEnter(GameEntity entity, EntityState<GameEntity> previousState, EntityStateMachine<GameEntity> fsm)
        {
            if (!entity.GetComponent<MovableEntity>().Jump())
                return false;

            return base.OnEnter(entity, previousState, fsm);
        }

        public override void OnUpdate(GameEntity entity, EntityStateMachine<GameEntity> fsm)
        {
            entity.GetComponent<MovableEntity>().EnableGravity = true;
            // Movement
            var movement = InputManager.Instance.GetMovement();
            movement.y = 0;
            entity.GetComponent<MovableEntity>().Move(movement);

            // Jump
            if (InputManager.Instance.GetAction(InputManager.Instance.JumpAction))
            {
                if (entity.GetComponent<MovableEntity>().Jump())
                    fsm.ChangeState(this);
            }

            entity.GetComponent<AnimationController>().PlayAnimation(AnimatorController, InputManager.Instance.GetMovement().x);
            if (entity.GetComponent<MovableEntity>().OnGround)
                fsm.ChangeState(IdleState);
        }
    }

}