using UnityEngine;
using System.Collections;

public class AnimatedState<TEntity> : EntityState<TEntity> where TEntity:GameEntity
{
    public RuntimeAnimatorController AnimatorController;
    public string TriggerName = "";

}
