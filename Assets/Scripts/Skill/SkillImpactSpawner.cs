using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SkillImpactSpawner : EntityBehaviour<GameEntity>
{
    public GameObject Prefab;
    public Vector2 SpawnOffset;
    public float TimeOffset = 0;
    public SkillImpact Instance;
    

    IEnumerator SpawnCoroutine(List<EffectInstance> effects)
    {
        yield return new WaitForSeconds(TimeOffset);
        var impact = Utility.Instantiate(Prefab, Entity.gameObject.scene).GetComponent<SkillImpact>();
        impact.Creator = Entity;
        impact.Effects = effects;
        Vector3 direction = Vector3.right * Entity.GetComponent<MovableEntity>().FaceDirection;
        var offset = SpawnOffset;
        offset.x *= Entity.GetComponent<MovableEntity>().FaceDirection;
        impact.Activate(Entity.transform.position + offset.ToVector3(), direction);
        Instance = impact;
    }

    public void Spawn(List<EffectInstance> effects, float dir)
    {
        if(TimeOffset>0)
        {
            StartCoroutine(SpawnCoroutine(effects));
        }
        else
        {
            var impact = Utility.Instantiate(Prefab, Entity.gameObject.scene).GetComponent<SkillImpact>();
            impact.Creator = Entity;
            impact.Effects = effects;
            Vector3 direction = Vector3.right * dir;
            var offset = SpawnOffset;
            offset.x *= dir;
            impact.Activate(Entity.transform.position + offset.ToVector3(), direction);
            Instance = impact;
        }
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
