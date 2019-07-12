using UnityEngine;
using System.Collections;

public class AnimatedState : EntityState
{
    public AudioClip SoundEffect;
    public RuntimeAnimatorController AnimatorController;
    public string TriggerName = "";

    public override bool OnEnter(GameEntity entity, EntityState previousState, EntityStateMachine fsm)
    {
        if (SoundEffect)
            entity.GetComponent<AudioController>().PlayEffect(SoundEffect);
        if (previousState == this)
            OnRePlay(entity, fsm);
        else
            Animate(entity, entity.GetComponent<MovableEntity>().FaceDirection);
        return true;
    }

    public override void OnUpdate(GameEntity entity, EntityStateMachine fsm)
    {
        Animate(entity, 0);
    }

    public void Animate(GameEntity entity, float direction)
    {
        if (AnimatorController)
            entity.GetComponent<AnimationController>().ChangeAnimation(AnimatorController, direction);
    }

    protected virtual void OnRePlay(GameEntity entity, EntityStateMachine fsm)
    {
        Animate(entity, entity.GetComponent<MovableEntity>().FaceDirection);
    }
}
