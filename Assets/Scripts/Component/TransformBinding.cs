using UnityEngine;
using System.Collections;

public class TransformBinding : MonoBehaviour
{
    public Transform target;
    Vector3 offset;

    void Start()
    {
        if (target)
            Bind(target);
    }

    private void LateUpdate()
    {
        if (target)
            transform.position = target.position + offset;
    }

    public void Bind(Transform target)
    {
        this.target = target;
        offset = transform.position - target.position;
    }

    public void BindFromEvent()
    {
        var eventBus = GetComponent<EventBus>();
        if (!eventBus || eventBus.CurrentArgs.Length <= 0)
            return;
        var obj = eventBus.CurrentArgs[0] as GameObject;
        Bind(obj.transform);
    }
}
