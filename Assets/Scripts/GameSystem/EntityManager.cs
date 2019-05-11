using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class EntityManager : Singleton<EntityManager>
{
    public List<Entity> Entities = new List<Entity>();
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Entities = Entities.Where(entity => entity).ToList();
    }

    public static Entity FindEntity(string name)
    {
        return Instance?.Entities
            .Where(entity => entity && entity.gameObject.name == name)
            .FirstOrDefault();
    }

    public static EntityT FindEntity<EntityT>(string name) where EntityT: Entity
    {
        return Instance?.Entities
            .Where(entity => entity && entity is EntityT && entity.name == name)
            .FirstOrDefault() as EntityT;
    }

    public static EntityT[] FindEntities<EntityT>() where EntityT:Entity
    {
        return Instance?.Entities
            .Where(entity => entity && entity is EntityT)
            .Select(entity => entity as EntityT)
            .ToArray();
    }
}
