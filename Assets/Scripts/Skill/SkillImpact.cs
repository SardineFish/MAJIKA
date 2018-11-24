using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using SardineFish.Unity.FSM;
using System.Linq;

public enum ImpactType
{
    OnEntity,
    Collider,
    Manual,
    DropAttack
}
public enum ImpactDirection
{
    Ignore,
    Flip,
    FlipObject,
    Rotate
}
public enum ImpactLifeCycle
{
    Manual,
    DestructOnHit,
    LifeTime,
}
public enum ImpactDistance
{
    Unlimited,
    InScreen,
    FullMap,
    Constant,
}
[RequireComponent(typeof(EventBus))]
public class SkillImpact : MonoBehaviour
{
    public const string EventDeactivate = "Deactivate";
    public ImpactType ImpactType;
    public ImpactDirection ImpactDirection;
    public bool Continuous = false;
    public ImpactLifeCycle ImpactLifeCycle = ImpactLifeCycle.Manual;
    public float LifeTime = -1;
    public bool IgnoreCreator = true;
    public GameObject NextImpact;
    [HideInInspector]
    public List<EffectInstance> Effects = new List<EffectInstance>();
    public GameEntity Creator;
    public bool Active = false;
    public Vector3 Direction;

    private List<GameEntity> impactedList = new List<GameEntity>();

    private void Update()
    {
        
        if (Continuous)
        {
            impactedList.ForEach(ApplyDamage);
            impactedList.Clear();
        }
    }

    private void ApplyDamage(GameEntity entity)
    {
        if (NextImpact && NextImpact.GetComponent<SkillImpact>())
        {
            var impact = Utility.Instantiate(NextImpact, Creator.gameObject.scene).GetComponent<SkillImpact>();
            impact.Creator = Creator;
            impact.Effects = Effects;
            impact.Activate(transform.position, Direction);
        }
        else
        {
            var data = new ImpactData() { position = transform.position, Creator = Creator };
            new SkillImpactMessage(this, Effects.Select(effect => effect.Effect.Create(effect, data, this.Creator)).ToArray()).Dispatch(entity);
        }
    }

    public void Activate(Vector3 position, Vector3 direction)
    {
        Direction = direction;
        transform.position = position;
        if(ImpactDirection == ImpactDirection.Flip)
        {
            direction.y = direction.z = 0;
            direction = direction.normalized;
            transform.rotation *= Quaternion.FromToRotation(transform.right, direction);
            transform.Find("Renderer").localRotation *= Quaternion.FromToRotation(Vector3.right, direction);
            transform.Find("Renderer").localScale = new Vector3(direction.x, 1, 1);
            //transform.Find("Collider").localRotation *= Quaternion.FromToRotation(Vector3.right, direction);
        }
        else if (ImpactDirection == ImpactDirection.Rotate)
        {
            transform.rotation *= Quaternion.FromToRotation(transform.right, direction);
        }
        else if (ImpactDirection == ImpactDirection.FlipObject)
        {
            transform.localScale = new Vector3(direction.x, 1, 1);
        }

        if (LifeTime >= 0)
            StartCoroutine(LifeTimeCoroutine());
    }
    public void Deactivate()
    {
        GetComponent<EventBus>().Dispatch(EventDeactivate);
        Active = false;
    }

    public IEnumerator LifeTimeCoroutine()
    {
        yield return new WaitForSeconds(LifeTime);
        Deactivate();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        var entity = GameEntity.GetEntity(collision);
        if (!entity)
            return;
        if (IgnoreCreator && entity == Creator)
            return;
        if (Active == false)
            return;
        if (ImpactType == ImpactType.OnEntity)
            return;

        if (impactedList.Contains(entity))
            return;

        if (ImpactLifeCycle == ImpactLifeCycle.DestructOnHit)
            Deactivate();

        if (Continuous)
        {
            impactedList.Add(entity);
        }
        else
        {
            impactedList.Add(entity);
            ApplyDamage(entity);
        }
    }

    IEnumerator DropAttackCoroutine(float targetHeight)
    {
        var movement = GetComponent<SimpleMovement>();
        yield return movement.MoveTo(new Vector2(transform.position.x, targetHeight), () => transform.position.y <= targetHeight);
        transform.position = new Vector2(transform.position.x, targetHeight);
        if(NextImpact && NextImpact.GetComponent<SkillImpact>())
        {
            var impact = Utility.Instantiate(NextImpact, Creator.gameObject.scene).GetComponent<SkillImpact>();
            impact.Creator = Creator;
            impact.Effects = Effects;
            impact.Activate(transform.position, Direction);
        }
        Deactivate();
    }

    public void StartImpact()
    {
        Active = true;
        if (ImpactType == ImpactType.OnEntity)
        {
            ApplyDamage(Creator);
        }
        else if (ImpactType == ImpactType.DropAttack)
        {
            DropDownImpact();
        }
    }
    public void EndImpact()
    {
        Active = false;
    }

    public void DropDownImpact()
    {
        var hits = Physics2D.RaycastAll(transform.position, Vector2.down, 400, (1 << 8) | (1 << 9));
        if (hits.Length == 0)
        {
            GetComponent<SimpleMovement>().StartMovement();
            return;
        }
        hits = hits.OrderBy(hit => hit.point.y).ToArray();
        var targetHeight = hits.Min(hit => hit.point.y);
        if (targetHeight <= Creator.transform.position.y)
        {
            targetHeight = hits.Where(hit => hit.point.y <= Creator.transform.position.y).Max(hit => hit.point.y);
        }
        StartCoroutine(DropAttackCoroutine(targetHeight));
    }
}
