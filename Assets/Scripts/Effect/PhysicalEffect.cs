using UnityEngine;
using System.Collections;

public abstract class PhysicalEffect : Effect
{
    public override void OnStart(EffectInstance instance, EntityEffector effector)
    {
        if (instance.Strength > 0)
            effector.Entity.GetComponent<MovableEntity>().PhysicalControl = true;
    }

    public override void OnEnd(EffectInstance instance, EntityEffector effector)
    {
        if (effector.GetEffect<PhysicalEffect>() == null)
            effector.Entity.GetComponent<MovableEntity>().PhysicalControl = false;

    }
}
