using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public enum ThreatType
{
    Enemy,
    ActiveSkill,
    Bullet,
}
[MoonSharp.Interpreter.MoonSharpUserData]
public class Threat
{
    [MoonSharp.Interpreter.MoonSharpHidden]
    public ThreatType Type;
    public string TypeName
    {
        get
        {
            switch(Type)
            {
                case ThreatType.ActiveSkill:
                    return "skill";
                case ThreatType.Bullet:
                    return "bullet";
            }
            return "";
        }
    }
    public Vector2 Position;
    public Vector2 Velocity;
}