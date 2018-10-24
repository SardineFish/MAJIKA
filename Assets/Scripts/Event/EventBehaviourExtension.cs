using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

public static class EventBehaviourExtension
{
    public static void Bind(this IEventBehaviour eventBehaviour, EventBus eventBus)
    {
        if (eventBehaviour.EventListeners == null)
        {
            eventBehaviour.EventListeners = eventBehaviour.GetType()
                .GetMethods(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance)
                .Where(method => method.GetCustomAttributes<EventListenerAttribute>().FirstOrDefault() != null)
                .Select(method => new ReflectEventListener(method.GetCustomAttribute<EventListenerAttribute>().EventName, method, eventBehaviour))
                .ToArray();
        }

        if (eventBehaviour.EventTarget)
        {
            foreach (var listener in eventBehaviour.EventListeners)
            {
                eventBehaviour.EventTarget.RemoveEventListener(listener.Method.GetCustomAttribute<EventListenerAttribute>().EventName, listener);
            }
        }

        eventBehaviour.EventTarget = eventBus;
        foreach (var listener in eventBehaviour.EventListeners)
        {
            eventBehaviour.EventTarget.AddEventListener(listener.Method.GetCustomAttribute<EventListenerAttribute>().EventName, listener);
        }

    }
    public static void UseEventListener<EntityT>(this EntityBehaviour<EntityT> entityBehavior, EventBus eventBus) where EntityT : GameEntity
    {
        (entityBehavior as IEventBehaviour)?.Bind(eventBus);
    }
    public static void UseEventListener<EntityT>(this EntityBehaviour<EntityT> entityBehavior) where EntityT: GameEntity
    {
        if (entityBehavior.Entity.GetComponent<EventBus>())
            (entityBehavior as IEventBehaviour)?.Bind(entityBehavior.Entity.GetComponent<EventBus>());
    }
}