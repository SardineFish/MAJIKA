using UnityEngine;
using System.Collections;

public class EventTrigger : MonoBehaviour
{
    public void TriggerLevelEvent(string eventName)
    {
        Level.Instance.GetComponent<EventBus>().Dispatch(eventName);
    }

    public void TriggerEvent(string eventName)
    {
        GetComponent<EventBus>()?.Dispatch(eventName);
    }
}
