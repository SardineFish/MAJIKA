using UnityEngine;
using System.Collections;
using MAJIKA.State;
using System.Collections.Generic;
using UnityEngine.InputSystem;

[RequireComponent(typeof(EventBus))]
public class EntityController : EntityStateMachine
{
    public const string EventHit = "Hit";
    public Locker Locker = new Locker();
    public AnimatedState InitialState;
    public EntityIdle IdleState;
    public EntitySkill SkillState;
    public EntityHit HitState;
    public EntityStun StunState;
    public EntityDead DeadState;
    

    public Vector2 Movement = Vector2.zero;
    public float ClimbSpeed = 0;
    public bool Jumped = false;
    public bool Climbed = false;
    public int SkillIndex = -1;
    public GameEntity SkillTarget = null;

    public override void OnActive()
    {
        if (!InitialState)
            InitialState = IdleState;
        ChangeState(InitialState);
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

    public override bool ChangeState(EntityState nextState)
    {
        if (!Entity.active)
            return false;
        if (Locker.Locked)
            return false;
        return base.ChangeState(nextState);
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
    public virtual bool Skill(int idx, GameEntity target)
    {
        if (Locker.Locked)
            return false;
        SkillIndex = idx;
        SkillTarget = target;
        GetComponent<MovableEntity>().FaceTo((target.transform.position - transform.position).x);
        var result = ChangeState(SkillState);
        SkillIndex = -1;
        SkillTarget = null;
        return result;
    }
    public virtual System.Guid Lock() => Lock(IdleState);
    public virtual System.Guid Lock(EntityState state)
    {
        ChangeState(state);
        return Locker.Lock();
    }
    public virtual bool UnLock(System.Guid id)
    {
        if (Locker.UnLock(id))
        {
            //ChangeState(IdleState);
            return true;
        }
        return false;
    }
    public virtual void UnLock()
    {
        Locker.UnLockAll();
        //ChangeState(IdleState);
    }

    public void ResetController()
    {
        Jumped = false;
        Movement = Vector2.zero;
        Climbed = false;
        SkillIndex = -1;
        ClimbSpeed = 0;
    }
}
