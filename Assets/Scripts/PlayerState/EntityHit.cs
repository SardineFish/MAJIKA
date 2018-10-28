using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName ="Hit",menuName ="EntityState/Hit")]
public class EntityHit : GameEntityState
{
    public EntityIdle IdleState;

    public override bool OnEnter(GameEntity entity, EntityState<GameEntity> previousState, EntityStateMachine<GameEntity> fsm)
    {
        entity.GetComponent<AnimationController>().ChangeAnimation(this.AnimatorController, (GameSystem.Instance.PlayerInControl.transform.position - entity.transform.position).x);
        //entity.GetComponent<AnimationController>().ChangeAnimation(AnimatorController, (GameSystem.Instance.PlayerInControl.transform.position - entity.transform.position).x);
        Utility.WaitForSecond(entity, () =>
        {
            fsm.ChangeState(IdleState);
        }, 0.5f);
        return base.OnEnter(entity, previousState, fsm);
    }

    public override void OnUpdate(GameEntity entity, EntityStateMachine<GameEntity> fsm)
    {
        base.OnUpdate(entity, fsm);
    }
}
