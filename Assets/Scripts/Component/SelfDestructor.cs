using UnityEngine;
using System.Collections;

public class SelfDestructor : MonoBehaviour
{
    public string EventTrigger = "";
    private void Start()
    {
        if (EventTrigger != "")
            GetComponent<EventBus>().AddEventListenerOnce(EventTrigger, Destruct);
    }
    public void Destruct()
    {
        Destroy(gameObject);
    }
}
