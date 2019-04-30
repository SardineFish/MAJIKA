using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

[CreateAssetMenu(fileName ="Damage",menuName ="StatusEffect/Damage")]
public class Damage : Effect
{
    public MAJIKAElementType ElementProperty;
    public float damage;
    public bool DPS = false;
    
    public override void OnStart(EffectInstance instance, EntityEffector effector)
    {
        effector.Entity.GetComponent<EventBus>().Dispatch("Hit");
        var applyDamage = DPS ? damage * Time.deltaTime : damage;
        effector.Entity.GetComponent<LifeEntity>()?.HP_Decrease(applyDamage * instance.Strength);
    }
}