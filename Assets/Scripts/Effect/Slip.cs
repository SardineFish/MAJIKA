using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName = "Slip", menuName = "StatusEffect/Slip")]
public class Slip : Effect
{
    public override void OnStart(EffectInstance instance, EntityEffector effector)
    {
        base.OnStart(instance, effector);
        effector.Entity.GetComponent<MovableEntity>().PhysicalControl = true;
    }

    public override void OnEnd(EffectInstance instance, EntityEffector effector)
    {
        base.OnEnd(instance, effector);
        effector.Entity.GetComponent<MovableEntity>().PhysicalControl = false;

    }
}
