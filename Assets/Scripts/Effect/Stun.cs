using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName = "Stun", menuName = "StatusEffect/Stun")]
public class Stun : Effect
{
    public override void OnStart(EffectInstance instance, EntityEffector effector)
    {
        instance.lockID = effector.Entity.GetComponent<EntityController>().Lock(effector.Entity.GetComponent<EntityController>().StunState);
    }

    public override void OnEnd(EffectInstance instance, EntityEffector effector)
    {
        effector.Entity.GetComponent<EntityController>().UnLock();
    }
}
