using UnityEngine;
using System.Collections;

public abstract class ControllerPlugin : EntityBehaviour
{
    public abstract Vector2 Movement { get; }
    public abstract int SkillIndex { get; }
    public abstract bool Jumped { get; }
    public abstract bool Climbed { get; }
    public abstract float FaceDirection { get; }
    public abstract GameEntity SkillTarget { get; }

    public virtual void OnUpdate(EntityController controller)
    {
        
    }
    public virtual void ResetController() { }
}
