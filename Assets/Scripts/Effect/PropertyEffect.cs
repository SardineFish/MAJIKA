using UnityEngine;
using System.Collections;

public class PropertyEffect : Effect
{
    public virtual bool EffectStart(IEffectorTrigger trigger, float multiple)
    {
        return true;
    }

    public virtual bool EffectEnd(IEffectorTrigger trigger, float multiple)
    {
        return true;
    }

    public virtual void EffectUpdate(IEffectorTrigger trigger, float multiple)
    {

    }
}
