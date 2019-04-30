using UnityEngine;
using System.Collections;
using System.Linq;

[CreateAssetMenu(fileName = "ElementBuffer", menuName = "StatusEffect/ElementBuffer")]
public class ElementBuffer : Effect
{
    public MAJIKAElementType Restrain;
    public float RestrainFactor = 0.5f;
    public MAJIKAElementType Weakness;
    public float WeaknessFactor = 2;

    public override void OnUpdate(EffectInstance instance, EntityEffector effector)
    {
        var effects = effector.GetEffects<Damage>();
        foreach(var effect in effects)
        {
            var damage = effect.Effect as Damage;
            if (damage.ElementProperty == Restrain)
                effect.Strength *= RestrainFactor;
            else if (damage.ElementProperty == Weakness)
                effect.Strength *= WeaknessFactor;

        }
    }
}
