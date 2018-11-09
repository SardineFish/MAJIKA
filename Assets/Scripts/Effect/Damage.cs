﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

[CreateAssetMenu(fileName ="Damage",menuName ="StatusEffect/Damage")]
public class Damage : Effect
{
    public float damage;
    
    public override void OnStart(EntityEffector effector, IEffectorTrigger trigger, float strength)
    {
        effector.Entity.GetComponent<EventBus>().Dispatch("Hit");
        effector.Entity.GetComponent<LifeEntity>()?.HP_Decrease(damage * strength);
    }
}