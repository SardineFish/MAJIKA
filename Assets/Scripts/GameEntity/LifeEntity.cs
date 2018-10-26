using UnityEngine;
using System.Collections;

public class LifeEntity : GameEntity, IHP
{
    public const string EventHPIncrease = "HPIncrease";
    public const string EventHPDecrease = "HPDecrease";

    public float HP = 100;

    public float MaxHP = 100;

    public bool HP_Decrease(float value)
    {
        HP += value;
        GetComponent<EventBus>().Dispatch(EventHPIncrease, value);
        return true;
    }

    public bool HP_Increase(float value)
    {
        HP -= value;
        GetComponent<EventBus>().Dispatch(EventHPDecrease, value);
        return true;
    }
}
