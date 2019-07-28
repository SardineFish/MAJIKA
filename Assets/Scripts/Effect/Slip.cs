using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName = "Slip", menuName = "StatusEffect/Slip")]
public class Slip : PhysicalEffect
{
    public float Drag = 0;
    public override void OnStart(EffectInstance instance, EntityEffector effector)
    {
        base.OnStart(instance, effector);
        var movable = effector.Entity.GetComponent<MovableEntity>();
        movable.PhysicalControl = true;
        movable.AddForce(Drag * -MathUtility.SignInt(movable.velocity.x) * Vector2.right, ForceMode2D.Force);
    }
    public override void OnUpdate(EffectInstance instance, EntityEffector effector)
    {
        base.OnUpdate(instance, effector);
        var movable = effector.Entity.GetComponent<MovableEntity>();
        movable.PhysicalControl = true;
        movable.AddForce(Drag * -MathUtility.SignInt(movable.velocity.x) * Vector2.right, ForceMode2D.Force);
    }
}
