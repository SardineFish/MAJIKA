using UnityEngine;
using System.Collections;
using State;

[RequireComponent(typeof(EventBus))]
public class EntityController : EntityStateMachine<GameEntity>
{
    public const string EventHit = "Hit";
    public const string EventDeath = "Death";
    public EntityIdle IdleState;
    public EntitySkill SkillState;
    public EntityHit HitState;
    public EntityDead DeadState;

    public bool Locked = false;

    public Vector2 Movement = Vector2.zero;
    public float ClimbSpeed = 0;
    public bool Jumped = false;
    public int SkillIndex = -1;
    // Use this for initialization
    void Start()
    {
        ChangeState(IdleState);
        GetComponent<EventBus>().AddEventListener(EventHit, () =>
         {
             ChangeState(HitState);
         });
        GetComponent<EventBus>().AddEventListener(EventDeath, () =>
        {
            ChangeState(DeadState);
        });

    }


    protected override void Update()
    {
        if (!Locked)
            base.Update();
        this.Movement = Vector2.zero;
        ClimbSpeed = 0;
        Jumped = false;
        SkillIndex = -1;
    }

    public virtual void Move(Vector2 movement) => Movement = movement;
    public virtual void Jump() => Jumped = true;
    public virtual void Climb(float climbSpeed) => ClimbSpeed = climbSpeed;
    public virtual void Skill(int idx) => SkillIndex = idx;
    public virtual void Lock() => Locked = true;
}
