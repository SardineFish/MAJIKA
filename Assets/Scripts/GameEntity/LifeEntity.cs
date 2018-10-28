using UnityEngine;
using System.Collections;

[RequireComponent(typeof(EntityEffector))]
public class LifeEntity : GameEntity, IHP
{
    public const string EventHPIncrease = "HPIncrease";
    public const string EventHPDecrease = "HPDecrease";

    public float HP = 100;

    public float MaxHP = 100;

    public void OnMessage(SkillImpactMessage msg)
    {
        var effector = GetComponent<EntityEffector>();
        msg.Effects.ForEach(effect => effector.AddEffect(effect, msg.SenderEntity));
    }

    public bool HP_Increase(float value)
    {
        HP += value;
        GetComponent<EventBus>().Dispatch(EventHPIncrease, value);
        return true;
    }

    public bool HP_Decrease(float value)
    {
        HP -= value;
        GetComponent<EventBus>().Dispatch(EventHPDecrease, value);
        return true;
    }
}
