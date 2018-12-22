using UnityEngine;
using System.Collections;
using State;
using System.Collections.Generic;

[RequireComponent(typeof(EventBus))]
public class EntityController : EntityStateMachine<GameEntity>
{
    public const string EventHit = "Hit";
    public const string EventDeath = "Death";
    public EntityIdle IdleState;
    public EntitySkill SkillState;
    public EntityHit HitState;
    public EntityDead DeadState;

    public List<ControllerPlugin> Plugins = new List<ControllerPlugin>();

    public bool Locked = false;

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
        Plugins.ForEach(plugin => plugin.OnUpdate(this));
    }

    public virtual void Move(Vector2 movement) => Movement = movement;
    public virtual void Jump() => Jumped = true;
    public virtual void Climb(float climbSpeed) => ClimbSpeed = climbSpeed;
    public virtual void Skill(int idx) => Skill(idx, Movement.x);

    public virtual bool Skill(int idx, float dir)
    {
        SkillIndex = idx;
        GetComponent<MovableEntity>().FaceTo(dir);
        var result = ChangeState(SkillState);
        SkillIndex = -1;
        return result;
    }
    public virtual void Lock() => Locked = true;
}
