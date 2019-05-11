using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using SardineFish.Unity.FSM;
using System.Linq;

public enum ImpactType
{
    OnEntity,
    Collider,
    ColliderCast,
    Manual,
    WholeScene,
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
public class SkillImpact : Entity
{
    public const int DamageLayerMask = 1 << 14;
    public const string EventDeactivate = "Deactivate";
    public ImpactType ImpactType;
    public ImpactDirection ImpactDirection;
    public bool Continuous = false;
    public ImpactLifeCycle ImpactLifeCycle = ImpactLifeCycle.Manual;
    public float LifeTime = -1;
    [SerializeField]
    public float FireRange = -1;
    public bool IgnoreCreator = true;
    public GameObject NextImpact;
    [HideInInspector]
    public List<EffectInstance> Effects = new List<EffectInstance>();
    public GameEntity Creator;
    public bool Active = false;
    public Vector3 Direction;
    public GameEntity TargetEntity;

    private List<GameEntity> impactedList = new List<GameEntity>();

    protected override void Update()
    {
        base.Update();
        if (Continuous)
        {
            //Debug.Log(impactedList.Count);
            impactedList.ForEach(ApplyDamage);
            //impactedList.Clear();
        }
    }

    private void ApplyDamage(GameEntity entity)
    {
        if (IgnoreCreator && entity == Creator)
            return;
        if (NextImpact && NextImpact.GetComponent<SkillImpact>())
        {
            var impact = Utility.Instantiate(NextImpact, Creator.gameObject.scene).GetComponent<SkillImpact>();
            impact.Creator = Creator;
            impact.Effects = Effects;
            impact.Activate(transform.position, Direction, TargetEntity);
        }
        else
        {
            var data = new ImpactData() { position = transform.position, Creator = Creator, ImpactType = ImpactType };
            new SkillImpactMessage(this, Effects.Select(effect => effect.Effect.Create(effect, data, this.Creator)).ToArray()).Dispatch(entity);
        }
    }

    public void Activate(Vector3 position, Vector3 direction, GameEntity targetEntity)
    {
        Direction = direction;
        transform.position = position;
        TargetEntity = targetEntity;
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
            direction = targetEntity.transform.position - transform.position;
            transform.rotation *= Quaternion.FromToRotation(transform.right, direction);
        }
        else if (ImpactDirection == ImpactDirection.FlipObject)
        {
            transform.localScale = new Vector3(MathUtility.SignInt(direction.x), 1, 1);
        }
        if (Active)
            StartImpact();

        if (LifeTime >= 0 || FireRange > 0)
            StartCoroutine(LifeTimeCoroutine());
    }
    public void Deactivate()
    {
        GetComponent<EventBus>().Dispatch(EventDeactivate);
        Active = false;
    }

    public IEnumerator LifeTimeCoroutine()
    {
        var startTime = Time.time;
        var startPos = transform.position.ToVector2();
        var lifeTime = LifeTime < 0 ? float.PositiveInfinity : LifeTime;
        var fireRange = FireRange < 0 ? float.PositiveInfinity : FireRange;
        while(Time.time - startTime <= lifeTime && (transform.position.ToVector2() - startPos).magnitude <= fireRange)
        {
            yield return null;
        }
        Deactivate();
    }

    private void OnTriggerEnter2D(Collider2D collision)
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

    private void OnTriggerExit2D(Collider2D collision)
    {
        var entity = GameEntity.GetEntity(collision);
        if (Continuous)
        {
            impactedList.Remove(entity);
        }
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
            impact.Activate(transform.position, Direction, TargetEntity);
        }
        Deactivate();
    }

    public void StartImpact()
    {
        Active = true;
        if (ImpactType == ImpactType.OnEntity)
        {
            ApplyDamage(Creator);
            if (ImpactLifeCycle == ImpactLifeCycle.DestructOnHit)
                Deactivate();
        }
        /*else if (ImpactType == ImpactType.DropAttack)
        {
            DropDownImpact();
        }*/
        else if(ImpactType == ImpactType.ColliderCast)
        {
            var hitEntities = new List<GameEntity>();
            var box = GetComponentInChildren<BoxCollider2D>();
            var circle = GetComponentInChildren<CircleCollider2D>();
            var capsule = GetComponentInChildren<CapsuleCollider2D>();
            var pos = box
                ? transform.localToWorldMatrix.MultiplyPoint(box.offset)
                : circle
                    ? transform.localToWorldMatrix.MultiplyPoint(circle.offset)
                    : capsule
                        ? transform.localToWorldMatrix.MultiplyPoint(capsule.offset)
                        : transform.position;
            if (box)
            {
                var hits = Physics2D.BoxCastAll(pos, box.size, 0, Vector2.zero, 0, DamageLayerMask);
                hitEntities.AddRange(
                    hits.Select(hit => hit.transform.GetComponentInParent<GameEntity>())
                        .Where(entity => entity)
                        .ToList());
            }
            if(circle)
            {
                var hits = Physics2D.CircleCastAll(pos, circle.radius, Vector2.zero, 0, DamageLayerMask);
                hitEntities.AddRange(
                    hits.Select(hit => hit.transform.GetComponentInParent<GameEntity>())
                        .Where(entity => entity)
                        .ToList());
            }
            if (capsule)
            {
                var hits = Physics2D.CapsuleCastAll(pos, capsule.size, capsule.direction, 0, Vector2.zero, 0, DamageLayerMask);
                hitEntities.AddRange(
                    hits.Select(hit => hit.transform.GetComponentInParent<GameEntity>())
                        .Where(entity => entity)
                        .ToList());
            }
            hitEntities
                .Distinct()
                .ForEach(entity => ApplyDamage(entity));
            EndImpact();
        }
        else if (ImpactType == ImpactType.WholeScene)
        {
            Resources.FindObjectsOfTypeAll<GameEntity>()
                .Where(entity => entity.gameObject.scene != null)
                .ForEach(entity => ApplyDamage(entity));
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
