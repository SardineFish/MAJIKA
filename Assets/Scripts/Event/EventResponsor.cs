using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class EventResponsor : MonoBehaviour
{
    public EventBus EventBus;
    public List<EventResponse> Responsors = new List<EventResponse>();

    private List<EventListenerBase> listeners = new List<EventListenerBase>();

    private void Reset()
    {
        EventBus = GetComponent<EventBus>();
    }

    private void Awake()
    {
        if (!EventBus)
            return;
        foreach(var responsor in Responsors)
        {
            Action handler = () =>
            {
                responsor.Handle(gameObject);
            };
            listeners.Add(EventBus.AddEventListener(responsor.Event, handler));
            
        }
    }

    private void OnDestroy()
    {
        if (!EventBus)
            return;
        foreach(var listener in listeners)
        {
            EventBus.RemoveEventListener(listener);
        }
    }
}
