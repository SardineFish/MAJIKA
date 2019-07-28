using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName ="Interruption", menuName ="StatusEffect/Interruption")]
public class Interruption : Effect
{
    public override EffectInstance Merge(EffectInstance originalInstance, EffectInstance instance, EntityEffector effector)
    {
        originalInstance.Triggers = originalInstance.Strength < instance.Strength
            ? instance.Triggers
            : originalInstance.Triggers;
        originalInstance.Strength = Mathf.Max(originalInstance.Strength, instance.Strength);
        originalInstance.Duration = Mathf.Max(originalInstance.Duration, instance.Duration);
        return originalInstance;
    }
}
