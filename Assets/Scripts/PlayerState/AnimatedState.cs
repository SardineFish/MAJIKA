using UnityEngine;
using System.Collections;

public class AnimatedState<TEntity> : EntityState<TEntity> where TEntity:GameEntity
{
    public AudioClip Audio;
    public RuntimeAnimatorController AnimatorController;
    public string TriggerName = "";

    public override bool OnEnter(TEntity entity, EntityState<TEntity> previousState, EntityStateMachine<TEntity> fsm)
    {
        entity.GetComponent<AudioController>().PlayAudio(Audio);
        Animate(entity, 0);
        return true;
    }

    public override void OnUpdate(TEntity entity, EntityStateMachine<TEntity> fsm)
    {
        Animate(entity, 0);
    }

    public void Animate(TEntity entity, float direction)
    {
        if (AnimatorController)
            entity.GetComponent<AnimationController>().ChangeAnimation(AnimatorController, direction);
    }
}
