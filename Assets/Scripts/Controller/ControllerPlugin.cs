using UnityEngine;
using System.Collections;

public abstract class ControllerPlugin : EntityBehaviour<GameEntity>
{
    public virtual void OnUpdate(EntityController controller)
    {

    }
}
