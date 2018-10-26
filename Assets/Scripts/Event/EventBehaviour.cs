using UnityEngine;
using System.Collections;
using System;
using System.Reflection;
using System.Linq;

public class EventBehaviour : MonoBehaviour
{
    public EventBus EventTarget { get; set; }
    protected ReflectEventListener[] EventListeners;

    public EventBehaviour() : base()
    {

    }

    public EventBehaviour(EventBus eventBus) : this()
    {
        Bind(eventBus);
    }

    public void Bind(EventBus eventBus)
    {
        if(EventListeners == null)
        {
            EventListeners = GetType()
                .GetMethods(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance)
                .Where(method => method.GetCustomAttributes<EventListenerAttribute>().FirstOrDefault() != null)
                .Select(method => new ReflectEventListener(method.GetCustomAttribute<EventListenerAttribute>().EventName, method, this))
                .ToArray();
        }

        if(EventTarget)
        {
            foreach(var listener in EventListeners)
            {
                EventTarget.RemoveEventListener(/*listener.Method.GetCustomAttribute<EventListenerAttribute>().EventName, */listener);
            }
        }

        EventTarget = eventBus;
        foreach(var listener in EventListeners)
        {
            EventTarget.AddEventListener(listener.Method.GetCustomAttribute<EventListenerAttribute>().EventName, listener);
        }

    }
}
