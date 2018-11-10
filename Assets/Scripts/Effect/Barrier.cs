using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName ="Barrier",menuName ="StatusEffect/Barrier")]
public class Barrier : Effect
{
    public override void OnUpdate(EffectInstance instance, EntityEffector effector)
    {
        var damage = effector.GetEffect<Damage>();
        if (damage != null)
            damage.Strength = 0;
    }
}
