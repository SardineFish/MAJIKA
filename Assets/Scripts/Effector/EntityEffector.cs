using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class EntityEffector : EntityBehaviour<GameEntity>
{
    public List<ActiveEffect> Effects = new List<ActiveEffect>();

    List<ActiveEffect> removeList = new List<ActiveEffect>();
    
    List<ActiveEffect> newList = new List<ActiveEffect>();

    void Update()
    {
        // Remove effects
        foreach (var remove in removeList)
        {
            remove.Effect.OnEnd(this, remove.Trigger, remove.Strength);
            Effects.Remove(remove);
        }

        removeList.Clear();

        // Add new effects
        for(var i = 0; i < newList.Count; i++)
        {
            var newEffect = newList[i];
            var idx = Effects.FindIndex(effect => effect.Effect == newEffect.Effect);
            if(idx >=0)
            {
                newList[i] = Effects[idx] = newEffect.Effect.Merge(Effects[idx], this, newEffect.Trigger, newEffect.Strength);
            }
            else
            {
                Effects.Insert(0, newEffect);
            }
        }
        
        newList = new List<ActiveEffect>();

        Effects = Effects.OrderByDescending(effect => effect.Priority).ToList();
        
        Effects.ForEach(effect =>
        {
            if (effect.LifeTime == 0)
                effect.Effect.OnStart(this, effect.Trigger, effect.Strength);

            if(effect.Duration<=0)
            {
                removeList.Add(effect);
            }
            else
            {
                effect.Effect.OnUpdate(this, effect.Trigger, effect.Strength);
                effect.LifeTime += Time.deltaTime;
                if (effect.LifeTime >= effect.Duration)
                    removeList.Add(effect);
            }
        });
        
    }

    public ActiveEffect GetEffect<T>() where T : Effect
    {
        foreach(var effect in Effects)
        {
            if (effect.Effect is T)
                return effect;
        }
        return null;
    }

    public void AddEffect(EffectMultiplier effect, IEffectorTrigger trigger)
    {
        var activeEffect = effect.Effect.Create(this, trigger, effect.Multiple);
        newList.Add(activeEffect);
    }

    public void RemoveEffect(Effect effect)
    {
        var idx = Effects.FindIndex(e => e.Effect == effect);
        if (idx >= 0)
            removeList.Add(Effects[idx]);
    }
}
