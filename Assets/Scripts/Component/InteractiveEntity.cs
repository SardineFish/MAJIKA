using UnityEngine;
using System.Collections;

[RequireComponent(typeof(EventBus))]
public class InteractiveEntity : EntityBehaviour<GameEntity>
{
    public const string EventInteract = "OnInteract";
    public const string EventContactEnter = "OnContactEnter";
    public const string EventContactExit = "OnContactExit";

    public void Interact(GameEntity entity)
    {
        Entity.GetComponent<EventBus>().Dispatch(EventInteract, entity);
    }

    public void ContactEnter(GameEntity entity)
    {
        Entity.GetComponent<EventBus>().Dispatch(EventContactEnter, entity);
    }

    public void ContactExit(GameEntity entity)
    {
        Entity.GetComponent<EventBus>().Dispatch(EventContactExit, entity);
    }
}
