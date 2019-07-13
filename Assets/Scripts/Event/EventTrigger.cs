using UnityEngine;
using System.Collections;

public class EventTrigger : MonoBehaviour
{
    public EventBus EventBus;
    public string EventName;

    public float Delay = 0;

    private void Reset()
    {
        EventBus = GetComponent<EventBus>();
    }
    public void TriggerLevelEvent(string eventName)
    {
        Level.Instance.GetComponent<EventBus>().Dispatch(eventName);
    }

    public void TriggerEvent(string eventName)
    {
        GetComponent<EventBus>()?.Dispatch(eventName);
    }

    public void Trigger()
    {
        if (Delay > 0)
            StartCoroutine(DelayTrigger(EventBus, EventName, Delay));
        else
            EventBus.Dispatch(EventName);
    }

    IEnumerator DelayTrigger(EventBus eventBus, string eventName, float delay)
    {
        yield return new WaitForSeconds(delay);
        eventBus.Dispatch(eventName);
    }

}
