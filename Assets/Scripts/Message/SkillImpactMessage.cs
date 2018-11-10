using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SkillImpactMessage : EntityMessage
{
    public EffectInstance[] Effects;
    public SkillImpact Impact;
    public SkillImpactMessage(SkillImpact impact, params EffectInstance[] effects) : base(impact.Creator)
    {
        Impact = impact;
        Effects = effects;
    }
}