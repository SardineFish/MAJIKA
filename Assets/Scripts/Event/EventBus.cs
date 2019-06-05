using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class EventBus : MonoBehaviour
{
    public object[] CurrentArgs;
    public string CurrentEvent;
    private readonly Dictionary<string, List<EventListenerBase>> Listeners = new Dictionary<string, List<EventListenerBase>>();

    public EventBus()
    {
        Listeners = new Dictionary<string, List<EventListenerBase>>();
    }
    public void On(string eventName, ReflectEventListener listener)
        => AddEventListener(eventName, listener);
    public void On<T>(string eventName, Action<T> listener)
        => AddEventListener(eventName, listener);
    public void On(string eventName, Action listener)
        => AddEventListener(eventName, listener);
    public void AddEventListener(string eventName,ReflectEventListener listener)
    {
        if (!Listeners.ContainsKey(eventName))
            Listeners[eventName] = new List<EventListenerBase>();
        Listeners[eventName].Add(listener);

    }
    public ActionEventListener<T> AddEventListener<T>(string eventName, Action<T> listener,bool once = false)
    {
        if (!Listeners.ContainsKey(eventName))
            Listeners[eventName] = new List<EventListenerBase>();
        var eventListener = new ActionEventListener<T>(eventName, listener);
        Listeners[eventName].Add(eventListener);
        return eventListener;
    }
    public ActionEventListener<object> AddEventListener(string eventName, Action listener,bool once = false)
    {
        return AddEventListener<object>(eventName, (obj) => listener());
    }
    public void AddEventListenerOnce<T>(string eventName, Action<T> listener)
    {
        AddEventListener(eventName, listener, true);
    }
    public void AddEventListenerOnce(string eventName, Action listener)
    {
        AddEventListener(eventName, listener, true);
    }
    public void RemoveEventListener(EventListenerBase listener)
    {
        if (Listeners.ContainsKey(listener.EventName))
            Listeners[listener.EventName].Remove(listener);
    }
    public void Dispatch(string eventName,params object[] args)
    {
        CurrentArgs = args;
        CurrentEvent = eventName;

        if(Listeners.ContainsKey(eventName))
        {
            Listeners[eventName].ForEach(listener => listener.Invoke(args));
            for(var i=0;i<Listeners[eventName].Count;i++)
            {
                if (Listeners[eventName][i].Once)
                {
                    Listeners[eventName].RemoveAt(i--);
                }
            }
        }

        CurrentArgs = null;
        CurrentEvent = null;
    }
}
