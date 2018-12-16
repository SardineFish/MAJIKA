using UnityEngine;
using System.Collections;

public class AnimatedState<TEntity> : EntityState<TEntity> where TEntity:GameEntity
{
    public RuntimeAnimatorController AnimatorController;
    public string TriggerName = "";

    public override void OnUpdate(TEntity entity, EntityStateMachine<TEntity> fsm)
    {
        Animate(entity, 0);
    }

    public void Animate(TEntity entity, float direction)
    {
        entity.GetComponent<AnimationController>().ChangeAnimation(AnimatorController, direction);
    }
}
