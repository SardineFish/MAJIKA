using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class ActiveEffect
{
    public Effect Effect;
    public float Strength = 1;
    public Coroutine EffectCoroutine;
    public float Duration = 0;
    public float LifeTime = 0;
    public IEffectorTrigger Trigger;
    public int Priority = 0;
}