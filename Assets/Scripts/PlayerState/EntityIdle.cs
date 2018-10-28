using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName = "Idle", menuName = "EntityState/Idle")]
public class EntityIdle : GameEntityState
{
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
}
