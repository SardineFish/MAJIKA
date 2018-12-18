using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
public class MovableEntity : MonoBehaviour
{
    public const string ClimbAreaTag = "ClimbArea";
    //public bool Fly = false;
    public bool OnGround = false;
    public bool InClimbArea = false;
    public bool EnableGravity = true;
    public bool Frozen = false;
    public float FaceDirection = 1;
    public float MaxMoveSpeed = 10;
    public float MaxClimbSpeed = 10;
    public float JumpHeight = 5;
    public int MaxJumpCount = 1;

    public int jumpCount = 0;
    public Vector2 velocity;

    public GameObject AvailableClimbArea;



    private Vector2 movementvelocity;
    private Vector2 forceVelocity;

    public bool Jump()
    {
        if (Frozen)
            return false;
        EnableGravity = true;
        if (jumpCount-- > 0)
        {
            forceVelocity.y = PhysicsSystem.Instance.JumpVelocoty;
            return true;
        }
        else
            return false;
    }

    public bool Move(Vector2 movement)
    {
        if (Frozen)
            return false;
        movementvelocity = movement * MaxMoveSpeed;
        return false;
    }

    public bool ForceMove(Vector2 velocity)
    {
        forceVelocity = velocity;
        return true;
    }

    public void ForceMoveTo(Vector2 position)
    {
        transform.position = position;
    }

    public bool Climb(float speed)
    {
        if (!InClimbArea)
            return false;
        jumpCount = MaxJumpCount;
        transform.position = transform.position.Set(x: AvailableClimbArea.transform.position.x);
        movementvelocity = new Vector2(0, speed * MaxClimbSpeed);
        EnableGravity = false;
        return true;
    }

    private void LateUpdate()
    {
        if (!enabled)
            return;
        if (Frozen)
            return;

        FaceDirection = velocity.x == 0 ? FaceDirection : Mathf.Sign(velocity.x);
        if (EnableGravity)
        {
            GetComponent<Rigidbody2D>().gravityScale = 1;
            var v = GetComponent<Rigidbody2D>().velocity;
            v.x = 0;
            v += movementvelocity;
            if (Mathf.Abs(forceVelocity.y) > 0)
                v.y = forceVelocity.y;
            if (Mathf.Abs(forceVelocity.x) > 0)
                v.x = forceVelocity.x;

            GetComponent<Rigidbody2D>().velocity = v;
            velocity = v;
            forceVelocity = Vector2.zero;
            movementvelocity = Vector2.zero;
        }
        else
        {
            GetComponent<Rigidbody2D>().gravityScale = 0;
            var v = movementvelocity;
            /*if (additionalVelocity.y > 0)
                v.y = additionalVelocity.y;*/
            if (Mathf.Abs(forceVelocity.y) > 0)
                v.y = forceVelocity.y;
            if (Mathf.Abs(forceVelocity.x) > 0)
                v.x = forceVelocity.x;

            GetComponent<Rigidbody2D>().velocity = v;
            velocity = v;
            forceVelocity = Vector2.zero;
            movementvelocity = Vector2.zero;
        }
    }
    private void FixedUpdate()
    {
        OnGround = false;
        InClimbArea = false;
        AvailableClimbArea = null;

        GetComponent<Rigidbody2D>().gravityScale = EnableGravity ? 1 : 0;

    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        for (int i = 0; i < collision.contactCount; i++)
        {
            var contract = collision.GetContact(i);
            var localPoint = transform.worldToLocalMatrix.MultiplyPoint(contract.point);
            if (Mathf.Abs(localPoint.y) <= PhysicsSystem.Instance.OnGroundThreshold && contract.relativeVelocity.y >= 0)
            {
                jumpCount = MaxJumpCount;
                OnGround = true;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == ClimbAreaTag)
        {
            InClimbArea = true;
            AvailableClimbArea = collision.gameObject;
        }
    }
}
