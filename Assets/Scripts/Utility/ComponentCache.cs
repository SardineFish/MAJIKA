using UnityEngine;
using System.Collections;

public class ComponentCache<T> where T: Component
{
    GameObject gameobject;
    T component;

    public ComponentCache(GameObject gameobject)
    {
        this.gameobject = gameobject;
    }

    public static implicit operator T(ComponentCache<T> obj)
    {
        if (!obj.component)
            obj.component = obj.gameobject.GetComponent<T>();
        return obj.component;
    }

    public T Get()
    {
        if (!component)
            component = gameobject.GetComponent<T>();
        return component;
    }
}
