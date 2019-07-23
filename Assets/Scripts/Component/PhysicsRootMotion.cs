using UnityEngine;
using System.Collections;

[RequireComponent(typeof(MovableEntity), typeof(Animator))]
public class PhysicsRootMotion : MonoBehaviour
{
    public Vector3 Position;
    public bool EnableRootMotion;

    bool started = false;
    float lastTime = float.MaxValue;
    Vector3 origin = Vector3.zero;


    private void Start()
    {
        origin = transform.position;    
    }

    private void Update()
    {
        if (EnableRootMotion)
        {
            GetComponent<MovableEntity>().EnableGravity = false;
            started = true;
            GetComponent<MovableEntity>().Frozen = true;
        }
        else if (started)
        {
            GetComponent<MovableEntity>().Frozen = false;
            started = false;
            GetComponent<MovableEntity>().ResetDefault();
        }
    }

    private void LateUpdate()
    {
        var animator = GetComponent<Animator>();
        if (!animator)
            return;
        if (!animator.runtimeAnimatorController)
            return;
        if (animator.GetCurrentAnimatorStateInfo(0).normalizedTime < lastTime)
        {
            origin = transform.position;
        }
        lastTime = animator.GetCurrentAnimatorStateInfo(0).normalizedTime;
        
        if (EnableRootMotion)
        {
            var dir = MathUtility.SignInt(GetComponent<EntityController>().FaceDirection);
            GetComponent<MovableEntity>().ForceMoveTo(origin + Vector3.Scale(Position, new Vector3(dir, 1, 1)));
        }
    }
}
