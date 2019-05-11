using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

[RequireComponent(typeof(EventBus))]
public class GameEntity : Entity,IMessageSender,IMessageReceiver,IEffectorTrigger
{
    public const string NameRenderer = "Renderer";
    public const string NameCollider = "Collider";
    public const string NameAttached = "Attached";
    public const string NameSkills = "Skills";
    public const string NameInventory = "Inventory";
    public GameObject Renderer => transform.Find(NameRenderer).gameObject;
    public GameObject Collider => transform.Find(NameCollider).gameObject;

    public List<Effect> StatusEffects = new List<Effect>();

    public event Action OnUpdate;

    // Use this for initialization
    protected virtual void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        base.Update();
        OnUpdate?.Invoke();
        DetectThreat();
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

    public virtual Threat[] DetectThreat()
    {
        return new Threat[0];
    }

    public T GetEntityComponent<T>()
    {
        var component = GetComponent<T>();
        if (component == null)
            component = GetComponentInChildren<T>();
        return component;
    }
    public GameObject GetChild(string name)
    {
        return transform.Find(name).gameObject;
    }
}