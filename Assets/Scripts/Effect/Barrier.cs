using UnityEngine;
using System.Collections;

public enum DefenseType
{
    Bullet,
    Frozen,
    Flame,
    Physical,
    All = Bullet | Frozen | Flame | Physical,
}
[CreateAssetMenu(fileName ="Barrier",menuName ="StatusEffect/Barrier")]
public class Barrier : Effect
{
    public DefenseType DefenseType = DefenseType.All;
    public const string AnimEffectExit = "Exit";
    public GameObject ShieldDefenseEffect;
    public Vector3 Offset;
    public override void OnUpdate(EffectInstance instance, EntityEffector effector)
    {
        if ((DefenseType & DefenseType.Bullet) == DefenseType.Bullet)
        {
            var damage = effector.GetEffect<Damage>();
            if (damage != null)
            {
                if (ShieldDefenseEffect)
                {
                    var effect = Instantiate(ShieldDefenseEffect);
                    effect.transform.localScale = new Vector3(MathUtility.SignInt((damage.GetTrigger<ImpactData>().position - effector.Entity.transform.position).x), 1, 1);
                    effector.Entity.Attach(effect, Offset);
                }
                damage.Strength = 0;
            }
        }
        
    }

    public override void OnEnd(EffectInstance instance, EntityEffector effector)
    {
        base.OnEnd(instance, effector);
        if (instance.GameObjectInstance)
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
