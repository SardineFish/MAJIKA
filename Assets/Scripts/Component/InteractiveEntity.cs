using UnityEngine;
using System.Collections;

[RequireComponent(typeof(EventBus))]
public class InteractiveEntity : EntityBehaviour<GameEntity>
{
    public const string EventInteract = "OnInteract";
    public const string EventContactEnter = "OnContactEnter";
    public const string EventContactExit = "OnContactExit";

    public GameEntity ContactEntity { get; private set; }

    public void Interact(GameEntity entity)
    {
        Entity.GetComponent<EventBus>().Dispatch(EventInteract, entity);
    }

    public void Interact()
        => Interact(ContactEntity);

    public void ContactEnter(GameEntity entity)
    {
        Entity.GetComponent<EventBus>().Dispatch(EventContactEnter, entity);
        ContactEntity = entity;
    }

    public void ContactExit(GameEntity entity)
    {
        Entity.GetComponent<EventBus>().Dispatch(EventContactExit, entity);
        ContactEntity = null;
    }
}
