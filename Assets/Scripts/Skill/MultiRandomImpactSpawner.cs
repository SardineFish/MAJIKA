using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MultiRandomImpactSpawner : SkillImpactSpawner
{
    public Rect Range;

    public override void Spawn(List<EffectInstance> effects, float dir = 1, GameEntity target = null)
    {
        var pos = new Vector2(Random.Range(Range.xMin, Range.xMax), Random.Range(Range.yMin, Range.yMax));
        base.SpawnAt(effects, pos);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireCube(Range.center, Range.size);
    }
}
