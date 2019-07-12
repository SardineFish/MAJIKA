using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class EntityManager : Singleton<EntityManager>
{
    public static List<Entity> Entities;
    //public List<Entity> Entities = new List<Entity>();
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Entities = Entities.Where(entity => entity).ToList();
    }

    public static void RegisterEntity(Entity entity)
    {
        if (Entities == null)
            Entities = new List<Entity>();
        Entities.Add(entity);
    }

    public static void RemoveEntity(Entity entity)
    {
        Entities.Remove(entity);
    }

    public static Entity FindEntity(string name)
    {
        return Entities
            .Where(entity => IsInHierarchy(entity) && entity.gameObject.name == name)
            .FirstOrDefault();
    }

    public static EntityT FindEntity<EntityT>(string name) where EntityT: Entity
    {
        return Entities
            .Where(entity => IsInHierarchy(entity) && entity is EntityT && entity.name == name)
            .FirstOrDefault() as EntityT;
    }

    public static EntityT[] FindEntities<EntityT>() where EntityT:Entity
    {
        return Entities
            .Where(entity => IsInHierarchy(entity) && entity is EntityT)
            .Select(entity => entity as EntityT)
            .ToArray();
    }

    public static bool IsInHierarchy(Entity entity)
    {
        return entity 
            && entity.gameObject
            && entity.gameObject.scene != null 
            && entity.gameObject.scene.name != null;
    }

    public static bool IsPrefab(Entity entity)
    {
        return entity
            && entity.gameObject
            && (entity.gameObject.scene == null || entity.gameObject.scene.name == null);
    }
}
