using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SkillImpactMessage : EntityMessage
{
    public EffectMultiplier[] Effects;
    public SkillImpact Impact;
    public SkillImpactMessage(SkillImpact impact, params EffectMultiplier[] effects) : base(impact.Creator)
    {
        Impact = impact;
        Effects = effects;
    }
}