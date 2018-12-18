using UnityEngine;
using System.Collections;

[RequireComponent(typeof(MovableEntity), typeof(Animator))]
public class PhysicsRootMotion : MonoBehaviour
{
    public Vector3 Position;
    public bool EnableRootMotion;

    float lastTime = float.MaxValue;
    Vector3 origin = Vector3.zero;

    private void Start()
    {
        origin = transform.position;    
    }

    private void Update()
    {
        GetComponent<MovableEntity>().EnableGravity = !EnableRootMotion;
        GetComponent<MovableEntity>().Frozen = EnableRootMotion;
    }

    private void LateUpdate()
    {
        var animator = GetComponent<Animator>();
        if (!animator)
            return;
        if (animator.GetCurrentAnimatorStateInfo(0).normalizedTime < lastTime)
        {
            origin = transform.position;
        }
        lastTime = animator.GetCurrentAnimatorStateInfo(0).normalizedTime;
        
        if (EnableRootMotion)
        {
            var dir = MathUtility.SignInt(GetComponent<MovableEntity>().FaceDirection);
            GetComponent<MovableEntity>().ForceMoveTo(origin + Vector3.Scale(Position, new Vector3(dir, 1, 1)));
        }
    }
}
