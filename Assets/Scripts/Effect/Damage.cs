using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

[CreateAssetMenu(fileName ="Damage",menuName ="StatusEffect/Damage")]
public class Damage : Effect
{
    public float damage;
    public override bool EffectStart(EntityEffector effector, IEffectorTrigger trigger, float multiple)
    {
        effector.Entity.GetComponent<LifeEntity>()?.HP_Decrease(damage);
        return base.EffectStart(effector, trigger, multiple);
    }
}