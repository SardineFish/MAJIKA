using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(EventBus))]
public class GameEntity : MonoBehaviour,IMessageSender,IMessageReceiver,IEffectorTrigger
{
    public const string NameRenderer = "Renderer";
    public const string NameCollider = "Collider";
    public const string NameAttached = "Attached";
    public GameObject Renderer => transform.Find(NameRenderer).gameObject;
    public GameObject Collider => transform.Find(NameCollider).gameObject;

    public List<Effect> StatusEffects = new List<Effect>();

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public static GameEntity GetEntity(Component obj)
    {
        return obj.GetComponent<GameEntity>() ?? obj.GetComponentInParent<GameEntity>();
    }

    public void Attach(GameObject obj, Vector3 offset)
    {
        obj.transform.parent = transform;
        obj.transform.localPosition = offset;
    }

    public void Attach(GameObject obj)
    {
        Attach(obj, obj.transform.position - transform.position);
    }
}
