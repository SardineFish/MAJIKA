using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

[Serializable]
public class EffectInstance
{
    public Effect Effect;
    public float Strength = 1;
    public Coroutine EffectCoroutine;
    public float Duration = 0;
    public float LifeTime = 0;
    public EffectTriggerCollection Triggers = new EffectTriggerCollection();
    public int Priority = 0;
    public GameObject GameObjectInstance;
    [HideInInspector]
    public Guid lockID;

    public EffectInstance Clone()
    {
        return new EffectInstance()
        {
            Effect = this.Effect,
            Strength = this.Strength,
            EffectCoroutine = this.EffectCoroutine,
            Duration = this.Duration,
            LifeTime = this.LifeTime,
            Triggers = this.Triggers,
            Priority = this.Priority,
            GameObjectInstance = this.GameObjectInstance
        };
    }

    public T GetTrigger<T>() where T : IEffectorTrigger => Triggers.GetTrigger<T>();
}