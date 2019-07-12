using UnityEngine;
using System.Collections;

public abstract class EntityBehaviour : MonoBehaviour
{
    public GameEntity Entity
    {
        get
        {
            var entity = GetComponent<GameEntity>();
            if (entity == null || !entity)
                entity = GetComponentInParent<GameEntity>();
            return entity;
        }
    }

    public virtual void OnActive() { }
}
