using UnityEngine;
using System.Collections;
using State;

[CreateAssetMenu(fileName = "Idle", menuName = "EntityState/Idle")]
public class EntityIdle : GameEntityState
{
    public EntityMove MoveState;
    public EntitySkill SkillState;
    public EntityHit HitState;
    public override bool OnEnter(GameEntity entity, EntityState<GameEntity> previousState, EntityStateMachine<GameEntity> fsm)
    {
        entity.GetComponent<EventBus>().AddEventListenerOnce("Hit", () =>
        {
            fsm.ChangeState(HitState);
        });
        entity.GetComponent<AnimationController>().ChangeAnimation(AnimatorController, (GameSystem.Instance.PlayerInControl.transform.position - entity.transform.position).x);
        return base.OnEnter(entity, previousState, fsm);
    }

    public override void OnUpdate(GameEntity entity, EntityStateMachine<GameEntity> fsm)
    {
        // Skill
        if (InputManager.Instance.GetSkillIndex() >= 0)
            fsm.ChangeState(SkillState);

        // Movement
        var movement = InputManager.Instance.GetMovement();
        movement.y = 0;
        entity.GetComponent<MovableEntity>().Move(movement);
        if (!Mathf.Approximately(movement.x, 0))
            fsm.ChangeState(MoveState);
    }
}
