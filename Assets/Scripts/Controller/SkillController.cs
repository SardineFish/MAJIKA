using UnityEngine;
using System.Collections;
using System.Linq;

public class SkillController : EntityBehaviour
{
    public const string EventSkillEnd = "SkillEnd";
    public Skill EmptySkill;
    public Skill[] Skills;
    public Skill ActiveSkill = null;

    public GameEntity TargetEntity = null;

    private Coroutine movementCoroutine;

    void Update()
    {
        UpdateSkillList();
        if (ActiveSkill && GetComponent<Animator>().runtimeAnimatorController != ActiveSkill.AnimatorController)
            OnSkillEnd();
    }

    void UpdateSkillList()
    {
        Skills = GetComponentsInChildren<Skill>()
            .Where(skill => skill.gameObject)
            .ToArray();
    }

    public bool Activate(int idx, float direction=0)
    {
        if (idx >= Skills.Length)
            return false;
        if (ActiveSkill && !ActiveSkill.Abort())
            return false;
        if (!Skills[idx].Activate(direction))
            return false;
        ActiveSkill = Skills[idx];
        GetComponent<AnimationController>().PlayAnimation(ActiveSkill.AnimatorController, direction);
        return true;
    }

    public bool Activate(int idx, GameEntity entity)
    {
        if (idx >= Skills.Length)
            return false;
        if (ActiveSkill && !ActiveSkill.Abort())
            return false;
        if (!Skills[idx].Activate(entity))
            return false;
        TargetEntity = entity;
        ActiveSkill = Skills[idx];
        GetComponent<AnimationController>().PlayAnimation(ActiveSkill.AnimatorController, (entity.transform.position - transform.position).x);
        return true;
    }
    

    public Utility.CallbackYieldInstruction WaitSkillYield()
    {
        return new Utility.CallbackYieldInstruction(() => ActiveSkill && ActiveSkill.Locked);
    }

    public IEnumerator WaitSkill()
    {
        while (ActiveSkill && ActiveSkill.Locked)
            yield return null;
        yield break;
    }

    public IEnumerator WaitActivate(int idx)
    {
        if (Activate(idx))
            yield return WaitSkill();
    }

    public bool IsLocked()
    {
        if (!ActiveSkill)
            return false;
        return ActiveSkill.Locked;
    }

    public bool Abort()
    {
        if (!ActiveSkill)
            return true;
        return ActiveSkill.Abort();
    }

    void OnReleaseLock()
    {
        if (!ActiveSkill)
            return;
        ActiveSkill.Locked = false;
    }

    void OnSkillEnd()
    {
        OnReleaseLock();
        GetComponent<EventBus>().Dispatch(EventSkillEnd);
        ActiveSkill = null;
        movementCoroutine = null;
    }

    void SpawnImpact (int idx)
    {
        ActiveSkill?.StartImpact(idx);
    }

    void OnImpactStart()
    {
        ActiveSkill?.StartImpact();
    }

    void OnImpactEnd()
    {
        ActiveSkill?.EndImpact();
    }

    void OnSkillAudioEffect()
    {
        if (ActiveSkill)
            GetComponent<AudioController>().PlayEffect(ActiveSkill.AudioEffect);
    }

    IEnumerator MoveCoroutine(MovementSkill movement)
    {
        var endTime = Time.time + movement.Duration;
        var dir = movement.Direction;
        dir.x *= GetComponent<EntityController>().FaceDirection;
        while (Time.time <= endTime)
        {
            yield return null;
            GetComponent<MovableEntity>().ForceMove(dir.normalized * movement.Speed);
        }
    }

    void onSkillMovementStart()
    {
        if (!this.ActiveSkill)
            return;
        var movement = ActiveSkill.GetComponent<MovementSkill>();
        if (!movement)
            return;
        movementCoroutine = StartCoroutine(MoveCoroutine(movement));
    }

    void onSkillMovementEnd()
    {
        StopCoroutine(movementCoroutine);
        movementCoroutine = null;
    }

    public void AddSkill(Skill skill, int idx)
    {
        var obj = Instantiate(skill.gameObject);
        obj.transform.parent = Entity.GetChild(GameEntity.NameSkills).transform;
        obj.transform.localPosition = Vector3.zero;
        obj.transform.SetSiblingIndex(idx);
        UpdateSkillList();
    }

    public void RemoveSkill(int idx)
    {
        Destroy(Skills[idx].gameObject);
        UpdateSkillList();
    }

    public void SetSkills(Skill[] skills)
    {
        for(var i=0;i<skills.Length;i++)
        {
            if (skills[i])
                AddSkill(skills[i], i);
            else
                AddSkill(EmptySkill, i);
        }
    }

    public void ClearSkills()
    {
        Entity.GetChild(GameEntity.NameSkills).gameObject.DestroyChildren();
        UpdateSkillList();
    }
}
