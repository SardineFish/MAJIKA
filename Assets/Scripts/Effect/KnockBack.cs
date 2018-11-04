using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName = "KnockBack", menuName = "StatusEffect/KnockBack")]
public class KnockBack : Effect
{
    public float Distance = 4;
    public float Duration = 0.1f;
    
    public override IEnumerator EffectStart(EntityEffector effector, IEffectorTrigger trigger, float multiple)
    {
        var speed = Distance / Duration;
        var endTime = Time.time + Duration;
        var movableEntity = effector.Entity.GetComponent<MovableEntity>();
        var dir = effector.Entity.transform.position - (trigger as GameEntity).transform.position;
        dir = dir.normalized;
        effector.Entity.GetComponent<EventBus>().Dispatch("KnockBack");
        while (Time.time <= endTime)
        {
            movableEntity.ForceMove(dir * speed);
            yield return null;
        }
    }
}
