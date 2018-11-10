using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName = "KnockBack", menuName = "StatusEffect/KnockBack")]
public class KnockBack : Effect
{
    public float Distance = 4;

    public override void OnUpdate(EffectInstance instance, EntityEffector effector)
    {
        var speed = Distance / Duration;
        var endTime = Time.time + Duration;
        var movableEntity = effector.Entity.GetComponent<MovableEntity>();
        var dir = effector.Entity.transform.position - instance.Triggers.GetTrigger<GameEntity>().transform.position;
        dir = dir.normalized;
        effector.Entity.GetComponent<EventBus>().Dispatch("KnockBack");
        movableEntity.ForceMove(dir * speed);
    }
}
