using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName = "BlowUp", menuName = "StatusEffect/BlowUp")]
public class BlowUp : Effect
{
    public Vector2 Blow;

    public override void OnStart(EffectInstance instance, EntityEffector effector)
    {
        effector.Entity.GetComponent<EventBus>().Dispatch(EntityController.EventHit);
        base.OnStart(instance, effector);
    }
}
