using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using SardineFish.Unity.FSM;

public enum ImpactType
{
    OnEntity,
    Collider,
    Manual,
}
public enum ImpactDirection
{
    Ignore,
    Flip,
    Rotate
}
[RequireComponent(typeof(EventBus))]
public class SkillImpact : MonoBehaviour
{
    public const string EventDeactivate = "Deactivate";
    public ImpactType ImpactType;
    public ImpactDirection ImpactDirection;
    public bool ImpactOnce = true;
    public bool Continuous = false;
    [HideInInspector]
    public List<EffectMultiplier> Effects = new List<EffectMultiplier>();
    public GameEntity Creator;
    public bool Active = false;

    private List<GameEntity> impactedList = new List<GameEntity>();

    public void Activate(Vector3 position, Vector3 direction)
    {
        transform.position = position;
        if(ImpactDirection == ImpactDirection.Flip)
        {
            direction.y = direction.z = 0;
            direction = direction.normalized;
            transform.rotation *= Quaternion.FromToRotation(transform.right, direction);
            transform.Find("Renderer").localRotation *= Quaternion.FromToRotation(Vector3.right, direction);
            transform.Find("Renderer").localScale = new Vector3(direction.x, 1, 1);
        }
        else if (ImpactDirection == ImpactDirection.Rotate)
        {
            transform.rotation *= Quaternion.FromToRotation(transform.right, direction);
        }
        if (ImpactType == ImpactType.Collider)
            Active = true;
        else
            Active = false;
    }
    public void Deactivate()
    {
        GetComponent<EventBus>().Dispatch(EventDeactivate);
        Active = false;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        var entity = GameEntity.GetEntity(collision);
        if (!entity)
            return;
        if (entity == this.Creator)
            return;

        if (!Continuous && impactedList.Contains(entity))
            return;
        impactedList.Add(entity);

        if (ImpactOnce)
            Deactivate();

        new SkillImpactMessage(this, Effects.ToArray()).Dispatch(entity);
    }

    public void StartImpact()
    {
        Active = true;
    }
    public void EndImpact()
    {
        Active = false;
    }
}
