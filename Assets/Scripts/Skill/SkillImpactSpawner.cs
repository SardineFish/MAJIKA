using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(Skill))]
public class SkillImpactSpawner : EntityBehaviour<GameEntity>
{
    public GameObject Prefab;
    public Vector2 SpawnOffset;
    public SkillImpact Instance;

    public void Spawn(List<EffectMultiplier> effects)
    {
        var impact = Utility.Instantiate(Prefab, Entity.gameObject.scene).GetComponent<SkillImpact>();
        impact.Creator = Entity;
        impact.Effects = effects;
        Vector3 direction = Vector3.right * Entity.GetComponent<MovableEntity>().FaceDirection;
        var offset = SpawnOffset;
        offset.x *= Entity.GetComponent<MovableEntity>().FaceDirection;
        impact.Activate(Entity.transform.position + offset.ToVector3(), direction);
        Instance = impact;
    }

    public void Destory()
    {
        if (Instance)
            Destroy(Instance.gameObject);
    }

    public void Deactivate()
    {
        if (Instance)
            Instance.Deactivate();
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireSphere(transform.position + SpawnOffset.ToVector3(), 0.0625f);
    }
}
