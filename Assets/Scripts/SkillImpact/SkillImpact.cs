using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using SardineFish.Unity.FSM;

public enum ImpactType
{
    OnEntity,
    Collider
}
public enum ImpactDirection
{
    Ignore,
    Flip,
    Rotate
}
public class SkillImpact : MonoBehaviour
{
    public ImpactType ImpactType;
    public ImpactDirection ImpactDirection;
    public bool ImpactOnce = true;
    public bool Continuous = false;
    public List<EffectMultiplier> Effects = new List<EffectMultiplier>();
    public GameEntity Creator;
    public bool Active = false;

    private List<GameEntity> impactedList = new List<GameEntity>();

    public void Activate(Vector3 position, Vector3 direction)
    {
        transform.position = position;
        if(ImpactDirection == ImpactDirection.Flip)
        {
            transform.Find("Renderer").localScale = new Vector3(Mathf.Sign(direction.x), 1, 1);
        }
        else if (ImpactDirection == ImpactDirection.Rotate)
        {
            transform.rotation *= Quaternion.FromToRotation(transform.right, direction);
        }
        Active = true;
    }
    public void Deactivate()
    {
        Active = false;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        var entity = collision.GetComponent<GameEntity>();
        if (!entity)
            return;

        if (!Continuous && impactedList.Contains(entity))
            return;
        impactedList.Add(entity);

        if (ImpactOnce)
            Deactivate();

        new SkillImpactMessage(this, Effects.ToArray()).Dispatch(entity);
    }
}
