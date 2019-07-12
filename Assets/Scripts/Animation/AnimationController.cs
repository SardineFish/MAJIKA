using UnityEngine;
using System.Collections;

public enum DirectionImplement
{
    FlipRenderer,
    FlipRoot
}

[RequireComponent(typeof(PhysicsRootMotion))]
[RequireComponent(typeof(Animator))]
public class AnimationController : EntityBehaviour
{
    public bool ResetOnAwake = true;
    public DirectionImplement DirectionImplement = DirectionImplement.FlipRenderer;
    public int Direction = 0;

    Animator animator;
    PhysicsRootMotion rootMotion;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        rootMotion = GetComponent<PhysicsRootMotion>();

        if (ResetOnAwake)
            animator.runtimeAnimatorController = null;
    }

    public IEnumerator WaitAnimation()
    {
        while (!IsEnd())
            yield return null;
    }
    public Utility.CallbackYieldInstruction WaitAnimationYield()
    {
        return new Utility.CallbackYieldInstruction(() => !IsEnd());
    }
    public IEnumerator WaitAnimation(RuntimeAnimatorController animator,float direction)
    {
        if (!animator)
            yield break;
        this.animator.runtimeAnimatorController = animator;
        yield return null;
        while (GetComponent<Animator>().runtimeAnimatorController == animator && !IsEnd())
            yield return null;
    }
    public void PlayAnimation(RuntimeAnimatorController animator, float direction)
    {
        if (!Entity.active)
            return;

        if (Entity.GetComponent<Animator>().runtimeAnimatorController == animator && direction == MathUtility.SignInt(this.Direction))
            return;
        else
            ChangeAnimation(animator, direction);
    }
    public void ChangeAnimation(RuntimeAnimatorController animator, float direction)
    {
        if (!Entity.active)
            return;

        rootMotion.EnableRootMotion = false;
        this.animator.runtimeAnimatorController = animator;
        if(DirectionImplement == DirectionImplement.FlipRenderer)
        {
            if (direction > 0)
                Entity.Renderer.transform.localScale = new Vector3(1, 1, 1);
            else if (direction < 0)
                Entity.Renderer.transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (DirectionImplement == DirectionImplement.FlipRoot)
        {
            if (direction > 0)
                Entity.transform.localScale = new Vector3(1, 1, 1);
            else if (direction < 0)
                Entity.transform.localScale = new Vector3(-1, 1, 1);
        }
        this.Direction = MathUtility.SignInt(direction);
    }
    public bool IsEnd()
    {
        return animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1;
    }
}
