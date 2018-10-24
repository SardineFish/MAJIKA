using UnityEngine;
using System.Collections;

public abstract class Effect : ScriptableObject
{
    public virtual bool EffectStart(EntityEffector effector, IEffectorTrigger trigger, float multiple)
    {
        return true;
    }
    public virtual bool EffectEnd(EntityEffector effector, IEffectorTrigger trigger, float multiple)
    {
        return true;
    }
    public virtual bool EffectMerge(EntityEffector effector, IEffectorTrigger trigger, float multiple, EffectMerge merge)
    {
        return true;
    }
    public virtual void EffectUpdate(EntityEffector effector, IEffectorTrigger trigger, float multiple)
    {

    }
}
