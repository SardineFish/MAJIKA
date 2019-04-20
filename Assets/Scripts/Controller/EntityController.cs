using UnityEngine;
using System.Collections;
using State;
using System.Collections.Generic;
using UnityEngine.Experimental.Input;

[RequireComponent(typeof(EventBus))]
public class EntityController : EntityStateMachine<GameEntity>
{
    public const string EventHit = "Hit";
    public Locker Locker = new Locker();
    public EntityIdle IdleState;
    public EntitySkill SkillState;
    public EntityHit HitState;
    public EntityDead DeadState;
    

    public Vector2 Movement = Vector2.zero;
    public float ClimbSpeed = 0;
    public bool Jumped = false;
    public bool Climbed = false;
    public int SkillIndex = -1;
    
    // Use this for initialization
    void Start()
    {
        ChangeState(IdleState);
        GetComponent<EventBus>().AddEventListener(EventHit, () =>
         {
             ChangeState(HitState);
         });
        GetComponent<EventBus>().AddEventListener(LifeEntity.EventDeath, () =>
        {
            ChangeState(DeadState);
        });

    }


    protected override void Update()
    {
        GetComponents<ControllerPlugin>().ForEach(plugin =>
        {
            if (plugin.enabled)
                plugin.OnUpdate(this);
        });
        if (!Locker.Locked)
            base.Update();
        else if (State is EntityMove)
            ChangeState(IdleState);
    }

    public virtual void Move(Vector2 movement) => Movement = movement;
    public virtual void Jump() => Jumped = true;
    public virtual void Climb(float climbSpeed) => ClimbSpeed = climbSpeed;
    public virtual void Skill(int idx) => Skill(idx, Movement.x);

    public virtual bool Skill(int idx, float dir)
    {
        if (Locker.Locked)
            return false;
        SkillIndex = idx;
        GetComponent<MovableEntity>().FaceTo(dir);
        var result = ChangeState(SkillState);
        SkillIndex = -1;
        return result;
    }
    public virtual System.Guid Lock() => Locker.Lock();
    public virtual bool UnLock(System.Guid id) => Locker.UnLock(id);
    public virtual void UnLock() => Locker.UnLockAll();
}
