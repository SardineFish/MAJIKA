using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public enum EffectMerge
{
    None, 
    Additive,
    Multiple
}
public class EntityEffector : EntityBehaviour<GameEntity>
{
    public List<EffectMultiplier> Effects = new List<EffectMultiplier>();

    List<EffectMultiplier> removeList = new List<EffectMultiplier>();

    void Update()
    {
        Effects.ForEach(effect => effect.Effect.EffectUpdate(this, null, effect.Multiple));
        foreach (var remove in removeList)
            Effects.Remove(remove);
        removeList.Clear();
    }

    public bool AddEffect(EffectMultiplier effect, IEffectorTrigger trigger, EffectMerge merge = EffectMerge.Additive)
    {
        effect = effect.Clone();
        var existed = Effects.Where(eff => eff.Effect == effect.Effect).FirstOrDefault();
        if (existed!=null || merge == EffectMerge.None)
        {
            if (!existed.Effect.EffectMerge(this, trigger, effect.Multiple, merge))
                return false;
            switch (merge)
            {
                case EffectMerge.Additive:
                    existed.Multiple += effect.Multiple;
                    break;
                case EffectMerge.Multiple:
                    existed.Multiple *= effect.Multiple;
                    break;
            }
        }
        else
        {
            if (!effect.Effect.EffectStart(this, trigger, effect.Multiple))
                return false;
            Effects.Add(effect);
        }
        return true;
    }

    public bool RemoveEffect(Effect effect, IEffectorTrigger trigger) 
    {
        var existed = Effects.Where(eff => eff.Effect == effect).FirstOrDefault();
        if (existed == null)
            return true;
        if(existed.Effect.EffectEnd(this,trigger,existed.Multiple))
        {
            removeList.Add(existed);
            return true;
        }
        return false;
    }
}
