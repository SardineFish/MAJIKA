using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public enum SkillDirection
{
    Horizontal,
}
public class Skill : EntityBehaviour
{
    public RuntimeAnimatorController AnimatorController;
    public AudioClip AudioEffect;
    public bool LockAction = true;
    public float ReleaseRadius;
    public Vector3 ReleaseOffset;
    public float CoolDown = 1;
    public int InterruptLevel = 0;
    public bool Locked = false;
    public bool Ready = false;
    public Sprite Icon;

    private float lastActivateTime = 0;
    float Dir = 0;
    GameEntity TargetEntity = null;
    
    [HideInInspector]
    public List<EffectInstance> Effects = new List<EffectInstance>();

    void Update()
    {
        Ready = Time.time - lastActivateTime >= CoolDown;
        /*if(Active)
            Entity.GetComponent<AnimationController>().ChangeAnimation(AnimatorController, Entity.GetComponent<MovableEntity>().FaceDirection);*/
    }

    public bool Activate(float direction)
    {
        if (Time.time - lastActivateTime < CoolDown)
            return false;
        lastActivateTime = Time.time;
        Dir = direction;
        if (LockAction)
            Locked = true;

        return true;
    }

    public bool Activate(GameEntity entity)
    {
        if (Time.time - lastActivateTime < CoolDown)
            return false;
        lastActivateTime = Time.time;
        Dir = (entity.transform.position - transform.position).x;
        TargetEntity = entity;
        if (LockAction)
            Locked = true;

        return true;
    }

    public bool Interrupt(int level)
    {
        if(level >= InterruptLevel)
        {
            GetComponents<SkillImpactSpawner>().ForEach(spawner => spawner.DestoryImpactInstance());
            return true;
        }
        return false;
    }

    public bool Abort()
    {
        /*if (Locked)
            return false;*/

        GetComponents<SkillImpactSpawner>().ForEach(spawner => spawner.DestoryImpactInstance());
        return true;
    }

    public bool End()
    {
        return true;
    }

    public bool StartImpact(int idx = -1)
    {
        if (idx < 0)
            GetComponents<SkillImpactSpawner>().ForEach(spawner => spawner.Spawn(this.Effects, Dir, TargetEntity));
        else
            GetComponents<SkillImpactSpawner>()[idx].Spawn(this.Effects, Dir, TargetEntity);
        return true;
    }

    public bool EndImpact()
    {
        GetComponents<SkillImpactSpawner>().ForEach(spawner => spawner.Deactivate());
        return true;
    }

    private void OnDrawGizmosSelected()
    {
        /*
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireSphere(transform.position + ReleaseOffset, ReleaseRadius);*/
    }

    
}
