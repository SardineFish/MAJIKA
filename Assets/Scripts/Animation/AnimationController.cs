﻿using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Animator))]
public class AnimationController : EntityBehaviour<GameEntity>
{
    public int Direction = 0;
    public void PlayAnimation(RuntimeAnimatorController animator, float direction)
    {
        if (Entity.GetComponent<Animator>().runtimeAnimatorController == animator && direction == MathUtility.SignInt(this.Direction))
            return;
        else
            ChangeAnimation(animator, direction);
    }
    public void ChangeAnimation(RuntimeAnimatorController animator, float direction)
    {
        GetComponent<Animator>().runtimeAnimatorController = animator;
        if (direction > 0)
            Entity.Renderer.transform.localScale = new Vector3(1, 1, 1);
        else if (direction < 0)
            Entity.Renderer.transform.localScale = new Vector3(-1, 1, 1);
        this.Direction = MathUtility.SignInt(direction);
    }
}