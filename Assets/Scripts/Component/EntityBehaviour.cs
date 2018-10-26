using UnityEngine;
using System.Collections;

public class EntityBehaviour<T> : MonoBehaviour where T:GameEntity
{
    public T Entity
    {
        get
        {
            var entity = GetComponent<T>();
            if (entity == null || !entity)
                entity = GetComponentInParent<T>();
            return entity;
        }
    }
}
