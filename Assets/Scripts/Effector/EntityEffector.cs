using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class EntityEffector : EntityBehaviour
{
    public List<EffectInstance> Effects = new List<EffectInstance>();

    List<EffectInstance> removeList = new List<EffectInstance>();
    
    List<EffectInstance> newList = new List<EffectInstance>();
    
    void LateUpdate()
    {
        // Remove effects
        foreach (var remove in removeList)
        {
            remove.Effect.OnEnd(remove, this);
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
                newList[i] = Effects[idx] = newEffect.Effect.Merge(Effects[idx], newEffect, this);
            }
            else
            {
                Effects.Insert(0, newEffect);
            }
        }
        
        newList = new List<EffectInstance>();

        Effects = Effects.OrderByDescending(effect => effect.Priority).ToList();
        
        Effects.ForEach(effect =>
        {
            // Start effect
            if (effect.LifeTime == 0)
            {
                effect.Effect.OnStart(effect, this);
                if (effect.Effect.EffectPrefab)
                    effect.GameObjectInstance = effect.Effect.InstantiatePrefab(effect, this);
            }

            // Destroy instant effect
            if(effect.Duration==0)
            {
                removeList.Add(effect);
                if (effect.GameObjectInstance)
                    effect.Effect.DestroyInstance(effect.GameObjectInstance, effect, this);
            }

            // Update effects
            else
            {
                effect.Effect.OnUpdate(effect, this);
                effect.LifeTime += Time.deltaTime;
                if (effect.Duration > 0 && effect.LifeTime >= effect.Duration)
                {
                    removeList.Add(effect);
                    if (effect.GameObjectInstance)
                        effect.Effect.DestroyInstance(effect.GameObjectInstance, effect, this);
                }
            }
        });
        
    }

    public EffectInstance GetEffect<T>() where T : Effect
    {
        foreach(var effect in Effects)
        {
            if (effect.Effect is T)
                return effect;
        }
        return null;
    }

    public IEnumerable<EffectInstance> GetEffects<T>() where T: Effect
    {
        return Effects.Where(effect => effect.Effect is T);
    }

    public void AddEffect(EffectInstance effect, IEffectorTrigger trigger)
    {
        newList.Add(effect);
    }

    public void RemoveEffect(Effect effect)
    {
        var idx = Effects.FindIndex(e => e.Effect == effect);
        if (idx >= 0)
            removeList.Add(Effects[idx]);
    }
}
