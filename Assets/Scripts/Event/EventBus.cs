using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class EventBus : MonoBehaviour
{
    private readonly Dictionary<string, List<EventListenerBase>> Listeners = new Dictionary<string, List<EventListenerBase>>();

    public EventBus()
    {
        Listeners = new Dictionary<string, List<EventListenerBase>>();
    }
    public void AddEventListener(string eventName,ReflectEventListener listener)
    {
        if (!Listeners.ContainsKey(eventName))
            Listeners[eventName] = new List<EventListenerBase>();
        Listeners[eventName].Add(listener);

    }
    public void AddEventListener<T>(string eventName, Action<T> listener,bool once = false)
    {
        if (!Listeners.ContainsKey(eventName))
            Listeners[eventName] = new List<EventListenerBase>();
        Listeners[eventName].Add(new ActionEventListener<T>(listener));
    }
    public void AddEventListener(string eventName, Action listener,bool once = false)
    {
        AddEventListener<object>(eventName, (obj) => listener());
    }
    public void AddEventListenerOnce<T>(string eventName, Action<T> listener)
    {
        AddEventListener(eventName, listener, true);
    }
    public void AddEventListenerOnce(string eventName, Action listener)
    {
        AddEventListener(eventName, listener, true);
    }
    public void RemoveEventListener(string eventName, EventListenerBase listener)
    {
        if (Listeners.ContainsKey(eventName))
            Listeners[eventName].Remove(listener);
    }
    public void Dispatch(string eventName,params object[] args)
    {
        if(Listeners.ContainsKey(eventName))
        {
            Listeners[eventName].ForEach(listener => listener.Invoke(args));
            for(var i=0;i<Listeners.Count;i++)
            {
                if (Listeners[eventName][i].Once)
                {
                    Listeners[eventName].RemoveAt(i--);
                }
            }
            //Listeners[eventName].ForEach(listener => listener.Method.Invoke(listener.Object, args));
            /*try
            {
            }
            catch (Exception ex)
            {
                Debug.LogError(ex.Message);
            }*/
        }
    }
}
