using UnityEngine;
using System.Collections;

public enum ForceType
{
    Divergent,
    ImpactDirection,
    Constant,
}

public enum ForceApplyMode
{
    AddImpulse,
    ModifyMomentum,
}


[CreateAssetMenu(fileName = "Force", menuName = "StatusEffect/Force")]
public class Force : PhysicalEffect
{
    public ForceType ForceType;
    public Vector2 Impulse;
    public ForceApplyMode ForceApplyMode;
    public bool ConstraintX = false;
    public bool ConstraintY = false;


    public override void OnStart(EffectInstance instance, EntityEffector effector)
    {
        base.OnStart(instance, effector);
        instance.EffectCoroutine = effector.StartCoroutine(EffectCoroutine(instance, effector));
    }

    IEnumerator EffectCoroutine(EffectInstance instance, EntityEffector effector)
    {
        // Setup force
        var movable = effector.Entity.GetComponent<MovableEntity>();
        var impact = instance.GetTrigger<ImpactData>();
        if (impact is null)
            yield break;
        var dir = Vector2.zero;
        switch (ForceType)
        {
            case ForceType.Constant:
                dir = Impulse.normalized;
                break;
            case ForceType.Divergent:
                dir = effector.Entity.transform.position - impact.Position;
                break;
            case ForceType.ImpactDirection:
                dir = impact.Direction;
                break;
        }
        if (ConstraintX)
            dir.x = 0;
        if (ConstraintY)
            dir.y = 0;
        dir = dir.normalized;
        var f = dir * Impulse.magnitude * instance.Strength;

        movable.PhysicalControl = true;
        if (ForceApplyMode == ForceApplyMode.AddImpulse)
            movable.AddForce(f, ForceMode2D.Impulse);
        else if (ForceApplyMode == ForceApplyMode.ModifyMomentum)
            movable.SetMomentum(f);

        foreach (var t in Utility.Timer(Duration))
        {
            movable.PhysicalControl = true;
            yield return null;
        }
        do
        {
            movable.PhysicalControl = true;
            yield return null;
        }
        while (movable.EnableGravity && !movable.OnGround);
        if(effector.GetEffect<PhysicalEffect>()==null)
            movable.PhysicalControl = false;
        effector.RemoveEffect(instance.Effect);
    }

    public override void OnUpdate(EffectInstance instance, EntityEffector effector)
    {
        var impact = instance.GetTrigger<ImpactData>();
    }

    public override void OnEnd(EffectInstance instance, EntityEffector effector)
    {

    }

    public override EffectInstance Merge(EffectInstance originalInstance, EffectInstance instance, EntityEffector effector)
    {
        return originalInstance;
    }
}
