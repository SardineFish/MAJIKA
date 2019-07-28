using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName ="EffectShield", menuName ="StatusEffect/EffectShield")]
public class EffectShield : Effect
{
    public Effect Target;

    public override void OnUpdate(EffectInstance instance, EntityEffector effector)
    {
        for (var i = 0; i < effector.Effects.Count; i++)
        {
            if (effector.Effects[i].GetType() == Target.GetType())
            {
                effector.Effects[i].Strength = 0;
                effector.RemoveEffect(effector.Effects[i].Effect);
            }
        }
    }
}
