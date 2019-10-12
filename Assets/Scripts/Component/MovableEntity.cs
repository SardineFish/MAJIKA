using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
public class MovableEntity : MonoBehaviour
{
    public const string ClimbAreaTag = "ClimbArea";
    //public bool Fly = false;
    public bool PhysicalControl = false;
    public bool OnGround = false;
    public bool InClimbArea = false;
    public bool EnableGravity = true;
    public bool Frozen = false;

    public float MaxMoveForce = 30;
    public float MaxMoveSpeed = 10;
    public float MaxClimbSpeed = 10;
    public int MaxJumpCount = 1;
    public float GravityScale = 1;

    public int jumpCount = 0;

    public GameObject AvailableClimbArea;

    [ReadOnly]
    [HideInInspector]
    public Vector2 velocity;
    [ReadOnly]
    private Vector2 controledMovement;
    [ReadOnly]
    private Vector2 forceVelocity;
    [ReadOnly]
    private float climbSpeed;
    [ReadOnly]
    private Vector2 groundNormal;
    private Vector2 groundTangent;

    bool initialGravity;
    float initialMaxMoveSpeed;
    float initialMaxClimbSpeed;

    private void Start()
    {
        initialGravity = EnableGravity;
        initialMaxMoveSpeed = MaxMoveSpeed;
        initialMaxClimbSpeed = MaxClimbSpeed;
    }

    public void ResetDefault()
    {
        EnableGravity = initialGravity;
        MaxMoveSpeed = initialMaxMoveSpeed;
        MaxClimbSpeed = initialMaxClimbSpeed;

    }

    public bool Jump()
    {
        if (Frozen)
            return false;
        if (jumpCount-- > 0)
        {
            EnableGravity = true;
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
        controledMovement = movement;
        return true;
    }

    public bool ForceMove(Vector2 velocity)
    {
        forceVelocity = velocity;
        return true;
    }

    public void ForceMoveTo(Vector2 position)
    {
        //transform.position = position;
        GetComponent<Rigidbody2D>().MovePosition(position);
    }

    public void SetVelocity(Vector2 v)
    {
        GetComponent<Rigidbody2D>().velocity = v;
        velocity = v;
        Debug.Log(GetComponent<Rigidbody2D>().velocity);
    }
     
    public bool Climb(float normalizedSpeed)
    {
        if (!InClimbArea)
            return false;
        jumpCount = MaxJumpCount;
        transform.position = transform.position.Set(x: AvailableClimbArea.transform.position.x);
        climbSpeed = normalizedSpeed * MaxClimbSpeed;
        velocity.y = climbSpeed;
        EnableGravity = false;
        return true;
    }

    /*public bool FaceTo(float direction)
    {
        if (Frozen)
            return false;
        FaceDirection = direction == 0 ? FaceDirection : Mathf.Sign(direction);
        return true;
    }*/

    public bool AddForce(Vector2 force, ForceMode2D forceMode)
    {
        if (!PhysicalControl)
            return false;
        GetComponent<Rigidbody2D>().AddForce(force, forceMode);
        return true;
    }

    public bool SetMomentum(Vector2 momentum)
    {
        var rigidbody = GetComponent<Rigidbody2D>();
        var m = rigidbody.mass;
        var v = momentum / m;
        rigidbody.velocity = v;
        return true;
    }

    private void LateUpdate()
    {
        if (!enabled)
            return;
        if (Frozen)
            return;
        // FaceDirection = velocity.x == 0 ? FaceDirection : Mathf.Sign(velocity.x);
        if (PhysicalControl)
        {
            var rigidbody = GetComponent<Rigidbody2D>();
            rigidbody.gravityScale = EnableGravity ? GravityScale : 0;
            velocity = rigidbody.velocity;

            if (Mathf.Abs(climbSpeed) > 0)
                velocity.y = climbSpeed;
            if (!Mathf.Approximately(forceVelocity.x, 0))
                velocity.x = forceVelocity.x;
            if (!Mathf.Approximately(forceVelocity.y, 0))
                velocity.y = forceVelocity.y;
            rigidbody.velocity = velocity;

            // donot add force to player reaching speed limit.
            if (Mathf.Abs(velocity.x) < MaxMoveSpeed || MathUtility.SignInt(controledMovement.x) != MathUtility.SignInt(velocity.x))
            {
                var force = groundTangent * controledMovement + groundNormal * controledMovement.y;
                force *= MaxMoveForce;
                rigidbody.AddForce(force);
                velocity = rigidbody.velocity;
            }
        }
        else
        {
            if (EnableGravity)
            {
                GetComponent<Rigidbody2D>().gravityScale = GravityScale;
                var v = GetComponent<Rigidbody2D>().velocity;
                // Transform to ground coordinate & apply controls
                v = new Vector2(Vector2.Dot(v, groundTangent), Vector2.Dot(v, groundNormal));
                v.x = 0;
                v += controledMovement * MaxMoveSpeed;
                // Transfrom back to world coordinate
                v = v.x * groundTangent + v.y * groundNormal;

                if (Mathf.Abs(climbSpeed) > 0)
                    v.y = climbSpeed;
                if (Mathf.Abs(forceVelocity.y) > 0)
                    v.y = forceVelocity.y;
                if (Mathf.Abs(forceVelocity.x) > 0)
                    v.x = forceVelocity.x;

                GetComponent<Rigidbody2D>().velocity = v;
                velocity = v;
                forceVelocity = Vector2.zero;
                Debug.DrawLine(transform.position, transform.position + velocity.ToVector3(), Color.cyan);
            }
            else
            {
                GetComponent<Rigidbody2D>().gravityScale = 0;
                // Use ground coordinate to apply controls
                var v = controledMovement * MaxMoveSpeed;
                v = v.x * groundTangent + v.y * groundNormal;
                /*if (additionalVelocity.y > 0)
                    v.y = additionalVelocity.y;*/
                if (Mathf.Abs(climbSpeed) > 0)
                    v.y = climbSpeed;
                if (Mathf.Abs(forceVelocity.y) > 0)
                    v.y = forceVelocity.y;
                if (Mathf.Abs(forceVelocity.x) > 0)
                    v.x = forceVelocity.x;

                GetComponent<Rigidbody2D>().velocity = v;
                velocity = v;
                forceVelocity = Vector2.zero;
            }
        }
        climbSpeed = 0;
        forceVelocity = Vector2.zero;
        controledMovement = Vector2.zero;
    }
    private void FixedUpdate()
    {
        OnGround = false;
        InClimbArea = false;
        AvailableClimbArea = null;
        SetGroundNormal(Vector2.up);

        GetComponent<Rigidbody2D>().gravityScale = EnableGravity ? GravityScale : 0;

    }

    private void SetGroundNormal(Vector2 normal)
    {
        groundNormal = normal.normalized;
        groundTangent = Vector3.Cross(groundNormal.ToVector3(), Vector3.forward).ToVector2().normalized;
        Debug.DrawLine(transform.position, transform.position + groundNormal.ToVector3(), Color.green);
        Debug.DrawLine(transform.position, transform.position + groundTangent.ToVector3(), Color.red);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        for (int i = 0; i < collision.contactCount; i++)
        {
            var contract = collision.GetContact(i);
            var localPoint = transform.worldToLocalMatrix.MultiplyPoint(contract.point);
            var dot = Vector2.Dot(contract.normal, Vector2.up);
            if (dot < Mathf.Sqrt(.5f))
                continue;
            else if (Mathf.Approximately(1, dot)
                && Mathf.Abs(localPoint.y) <= PhysicsSystem.Instance.OnGroundThreshold 
                && contract.relativeVelocity.y >= 0)
            {
                SetGroundNormal(contract.normal);
                jumpCount = MaxJumpCount;
                OnGround = true;
            }
            else if (dot < 1 && Mathf.Abs(localPoint.y) <= 2 * PhysicsSystem.Instance.OnGroundThreshold && contract.normalImpulse >= 0)
            {
                SetGroundNormal(contract.normal);
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
