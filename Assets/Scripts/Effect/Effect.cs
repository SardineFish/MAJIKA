using UnityEngine;
using System.Collections;

public abstract class Effect : ScriptableObject
{
    public float Duration = 0;
    public int Priority = 0;

    public virtual void OnStart(EntityEffector effector, IEffectorTrigger trigger, float strength)
    {
    }

    public virtual void OnUpdate(EntityEffector effector, IEffectorTrigger trigger, float strength)
    {
    }

    public virtual void OnEnd(EntityEffector effector, IEffectorTrigger trigger, float strength)
    {
    }

    public virtual ActiveEffect Create(EntityEffector effector, IEffectorTrigger trigger, float strength)
    {
        return new ActiveEffect() { Effect = this, Duration = Duration, LifeTime = 0, Strength = strength, Trigger = trigger, Priority = Priority };
    }

    public virtual ActiveEffect Merge(ActiveEffect effect, EntityEffector effector, IEffectorTrigger trigger, float strength)
    {
        effect.Duration += Duration;
        effect.Strength += strength;
        effect.Trigger = trigger;
        return effect;
    }
}
