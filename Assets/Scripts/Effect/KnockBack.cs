using UnityEngine;
using System.Collections;
using System.Linq;

[CreateAssetMenu(fileName = "KnockBack", menuName = "StatusEffect/KnockBack")]
public class KnockBack : Effect
{
    public float Distance = 4;

    public override void OnUpdate(EffectInstance instance, EntityEffector effector)
    {
        var speed = Distance / Duration;
        var endTime = Time.time + Duration;
        var movableEntity = effector.Entity.GetComponent<MovableEntity>();
        var damageBody = effector.Entity.GetComponentsInChildren<Collider2D>().Where(collider => collider.gameObject.layer == 14).FirstOrDefault();
        var center = Vector2.zero;
        if (damageBody is CapsuleCollider2D)
        {
            center = (damageBody as CapsuleCollider2D).offset;
        }
        var dir = effector.Entity.transform.position.ToVector2() + center - instance.Triggers.GetTrigger<ImpactData>().Position.ToVector2();
        dir = dir.normalized;
        effector.Entity.GetComponent<EventBus>().Dispatch("KnockBack");
        movableEntity.ForceMove(dir * speed);
    }
}
