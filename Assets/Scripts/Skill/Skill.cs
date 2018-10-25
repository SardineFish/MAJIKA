using UnityEngine;
using System.Collections;

public enum SkillDirection
{
    Horizontal,
}
public class Skill : EntityBehaviour<GameEntity>
{
    public GameObject SkillImpactObject;
    public RuntimeAnimatorController AnimatorController;
    public Vector3 ImpactOffset;
    public SkillDirection Direction;
    public float CoolDown = 1;
    public bool LockState = false;

    private float lastActivateTime = 0;
    private SkillImpact releasedSkillImpact;

    public bool Activate()
    {
        if (Time.time - lastActivateTime < CoolDown)
            return false;
        lastActivateTime = Time.time;
        
        return true;
    }

    public bool Abort()
    {
        if (LockState)
            return false;

        if (releasedSkillImpact)
            releasedSkillImpact.Deactivate();
        return true;
    }

    public bool StartImpact()
    {
        if (releasedSkillImpact)
            return true;
        var impact = Utility.Instantiate(SkillImpactObject, Entity.gameObject.scene).GetComponent<SkillImpact>();
        impact.Creator = Entity;
        Vector3 direction = Vector3.right;
        switch (Direction)
        {
            case SkillDirection.Horizontal:
                direction = Vector3.right * Entity.GetComponent<MovableEntity>().FaceDirection;
                break;
        }
        impact.Activate(Entity.transform.position + ImpactOffset, direction);
        Entity.GetComponent<AnimationController>().ChangeAnimation(AnimatorController, direction.x);
        releasedSkillImpact = impact;
        return true;
    }

    public bool EndImpact()
    {
        releasedSkillImpact?.Deactivate();
        return true;
    }
}
