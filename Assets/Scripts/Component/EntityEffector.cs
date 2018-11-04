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
    public List<ActiveEffect> Effects = new List<ActiveEffect>();

    List<ActiveEffect> removeList = new List<ActiveEffect>();

    void Update()
    {
        foreach (var remove in removeList)
            Effects.Remove(remove);
        removeList.Clear();

        //Effects.ForEach(effect => effect.Effect.EffectUpdate(this, null, effect.Multiple));
        
    }

    IEnumerator StartEffect(ActiveEffect effect, IEffectorTrigger trigger)
    {
        yield return effect.Effect.EffectStart(this, trigger, effect.Multiplier);
        this.removeList.Add(effect);
    }

    public bool AddEffect(EffectMultiplier effect, IEffectorTrigger trigger, EffectMerge merge = EffectMerge.Additive)
    {
        effect = effect.Clone();
        var existed = Effects.Where(eff => eff.Effect == effect.Effect).FirstOrDefault();
        var activeEffect = new ActiveEffect { Effect = effect.Effect, Multiplier = effect.Multiple };
        activeEffect.EffectCoroutine = StartCoroutine(StartEffect(activeEffect, trigger));
        this.Effects.Add(activeEffect);
        /*
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
        }*/
        return true;
    }
    /*
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
    }*/
}
