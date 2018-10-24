using UnityEngine;
using System.Collections;

public class SkillController : EntityBehaviour<Player>
{
    public const string EventSkillEnd = "SkillEnd";
    public Skill[] Skills;
    public Skill ActiveSkill = null;

    void Update()
    {
        Skills = GetComponentsInChildren<Skill>();
    }

    public bool Activate(int idx)
    {
        if (idx >= Skills.Length)
            return false;
        if (ActiveSkill && !ActiveSkill.Abort())
            return false;
        if (!Skills[idx].Activate())
            return false;
        ActiveSkill = Skills[idx];
        return true;
    }

    public bool IsLocked()
    {
        if (!ActiveSkill)
            return false;
        return ActiveSkill.LockState;
    }

    public bool Abort()
    {
        if (!ActiveSkill)
            return true;
        return ActiveSkill.Abort();
    }

    void OnReleaseLock()
    {
        ActiveSkill.LockState = false;
    }

    void OnSkillEnd()
    {
        GetComponent<EventBus>().Dispatch(EventSkillEnd);
    }
}
