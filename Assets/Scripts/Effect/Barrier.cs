using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName ="Barrier",menuName ="StatusEffect/Barrier")]
public class Barrier : Effect
{
    public const string AnimEffectExit = "Exit";
    public Vector3 Offset;
    public override void OnUpdate(EffectInstance instance, EntityEffector effector)
    {
        var damage = effector.GetEffect<Damage>();
        if (damage != null)
            damage.Strength = 0;
    }

    public override void OnEnd(EffectInstance instance, EntityEffector effector)
    {
        base.OnEnd(instance, effector);
        DestroyInstance(instance.GameObjectInstance, instance, effector);
    }

    public override GameObject InstantiatePrefab(EffectInstance instance, EntityEffector effector)
    {
        var obj = base.InstantiatePrefab(instance, effector);
        effector.Entity.Attach(obj, Offset);
        return obj;
    }

    public override void DestroyInstance(GameObject obj, EffectInstance instance, EntityEffector effector)
    {
        obj.GetComponent<Animator>().SetTrigger(AnimEffectExit);
    }
}
