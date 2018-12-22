using UnityEngine;
using System.Collections;

public abstract class Effect : ScriptableObject
{
    [Tooltip("Life time of this effect, -1: infinite")]
    public float Duration = 0;
    public int Priority = 0;
    public GameObject EffectPrefab;

    public virtual void OnStart(EffectInstance instance, EntityEffector effector)
    {
    }

    public virtual void OnUpdate(EffectInstance instance, EntityEffector effector)
    {
    }

    public virtual void OnEnd(EffectInstance instance, EntityEffector effector)
    {
    }

    public virtual EffectInstance Create(EffectInstance effect, params IEffectorTrigger[] triggers)
    {
        var instance = new EffectInstance()
        {
            Effect = effect.Effect,
            Strength = effect.Strength,
            Duration = Duration,
            Priority = Priority,
            LifeTime = 0
        };
        instance.Triggers = new EffectTriggerCollection();
        instance.Triggers.AddRange(triggers);
        return instance;
    }

    public virtual EffectInstance Merge(EffectInstance originalInstance, EffectInstance instance, EntityEffector effector)
    {
        originalInstance.Duration += instance.Duration;
        originalInstance.Strength += instance.Strength;
        originalInstance.Triggers.AddRange(instance.Triggers);
        return originalInstance;
    }

    public virtual GameObject InstantiatePrefab(EffectInstance instance, EntityEffector effector)
    {
        var obj = Utility.Instantiate(EffectPrefab, effector.Entity.gameObject.scene);
        obj.transform.position = effector.Entity.transform.position;
        return obj;
    }

    public virtual void DestroyInstance(GameObject obj, EffectInstance instance, EntityEffector effector)
    {
        Destroy(obj);
    }
}
