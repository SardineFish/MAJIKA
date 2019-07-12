using UnityEngine;
using System.Collections;

public class EventTrigger : MonoBehaviour
{
    public EventBus EventBus;
    public string EventName;
    public bool TriggerOnAwake = false;
    // Use this for initialization
    void Start()
    {
        if (TriggerOnAwake)
            Trigger();
    }

    [EditorButton]
    public void Trigger()
    {
        EventBus?.Dispatch(EventName);
    }
}
