using UnityEngine;
using System.Collections;

[RequireComponent(typeof(EntityEffector))]
public class LifeEntity : GameEntity, IHP
{
    public const string EventHPIncrease = "HPIncrease";
    public const string EventHPDecrease = "HPDecrease";
    public const string EventDeath = "Die";
    public const string EventHit = "Hit";

    public float HP = 100;

    public float MaxHP = 100;

    protected override void Update()
    {
        base.Update();
        if (HP <= 0)
            GetComponent<EventBus>().Dispatch(EventDeath);
    }

    public void OnMessage(SkillImpactMessage msg)
    {
        var effector = GetComponent<EntityEffector>();
        msg.Effects.ForEach(effect => effector.AddEffect(effect, msg.SenderEntity));
        GetComponent<EventBus>().DispatchNextFrame(EventHit);
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
