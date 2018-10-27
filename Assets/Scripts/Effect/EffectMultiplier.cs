using UnityEngine;
using System.Collections;
using System;

[Serializable]
public class EffectMultiplier
{
    public Effect Effect;
    public float Multiple;

    public EffectMultiplier Clone()
    {
        return new EffectMultiplier() { Effect = this.Effect, Multiple = this.Multiple };
    }
}
