using UnityEngine;
using System.Linq;
using System.Collections;

public class Enemy : LifeEntity
{
    public override Threat[] DetectThreat()
    {
        var enemis = Entity.FindAll<Player>();

        return enemis.Select(player => new Threat()
        {
            Type = ThreatType.Enemy,
            Position = player.transform.position,
            Velocity = player.GetComponent<MovableEntity>().velocity
        })
            .Union(
                Entity.FindAll<SkillImpact>()
                .Where(impact => impact.ImpactType == ImpactType.Collider && impact.Creator is Player)
                .Select(impact => new Threat()
                {
                    Type = ThreatType.Bullet,
                    Position = impact.transform.position,
                    Velocity = impact.GetComponent<Rigidbody2D>().velocity
                }))
            .Union(
                enemis.Where(player => player.GetComponent<SkillController>().ActiveSkill)
                .Select(player => new Threat()
                {
                    Position = player.transform.position,
                    Velocity = player.GetComponent<MovableEntity>().velocity,
                    Type = ThreatType.ActiveSkill
                })
            ).ToArray();
    }
}
