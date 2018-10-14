using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
public class MovableEntity : MonoBehaviour
{
    //public bool Fly = false;
    public bool OnGround = false;
    public bool EnableGravity = true;
    public bool Frozen = false;
    public float MaxMoveSpeed = 10;
    public float JumpHeight = 5;
    public int MaxJumpCount = 1;

    public int jumpCount = 0;

    private Vector2 velocity;
    private Vector2 additionalVelocity;

    public bool Jump()
    {
        if (Frozen)
            return false;
        if (jumpCount-- > 0)
        {
            additionalVelocity.y = PhysicsSystem.Instance.JumpVelocoty;
            return true;
        }
        else
            return false;
    }

    public bool Move(Vector2 movement)
    {
        if (Frozen)
            return false;
        velocity = movement * MaxMoveSpeed;
        return false;
    }

    private void LateUpdate()
    {
        if (EnableGravity)
        {
            GetComponent<Rigidbody2D>().gravityScale = 1;
            var v = GetComponent<Rigidbody2D>().velocity;
            v.x = 0;
            v += velocity;
            if (additionalVelocity.y > 0)
                v.y = additionalVelocity.y;

            GetComponent<Rigidbody2D>().velocity = v;
            additionalVelocity = Vector2.zero;
            velocity = Vector2.zero;
        }
        else
        {
            GetComponent<Rigidbody2D>().gravityScale = 0;
            var v = velocity;
            if (additionalVelocity.y > 0)
                v.y = additionalVelocity.y;

            GetComponent<Rigidbody2D>().velocity = v;
            additionalVelocity = Vector2.zero;
            velocity = Vector2.zero;
        }
    }
    private void FixedUpdate()
    {
        OnGround = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        for (int i = 0; i < collision.contactCount; i++)
        {
            var contract = collision.GetContact(i);
            var localPoint = transform.worldToLocalMatrix.MultiplyPoint(contract.point);
            Debug.Log(localPoint.y);
            if (Mathf.Abs(localPoint.y) <= PhysicsSystem.Instance.OnGroundThreshold)
            {
                jumpCount = MaxJumpCount;
                OnGround = true;
            }
        }
    }
}
