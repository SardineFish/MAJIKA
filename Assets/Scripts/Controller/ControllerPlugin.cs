using UnityEngine;
using System.Collections;

public abstract class ControllerPlugin : ScriptableObject
{
    public virtual void OnUpdate(EntityController controller)
    {

    }
}
