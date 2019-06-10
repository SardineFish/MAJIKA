using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName ="Gravitate",menuName ="StatusEffect/Gravitate")]
public class Gravitate : Effect
{
    public float Speed = 10;

    public override void OnStart(EffectInstance instance, EntityEffector effector)
    {
        var dir = instance.GetTrigger<ImpactData>().Position - effector.Entity.transform.position;
        var velocity = dir.normalized * Speed;
        effector.Entity.GetComponent<MovableEntity>().ForceMove(velocity);
    }
}
