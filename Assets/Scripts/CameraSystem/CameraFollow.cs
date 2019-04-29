using UnityEngine;
using System.Collections;

[RequireComponent(typeof(BoxCollider2D))]
public class CameraFollow : CameraPlugin
{
    public float CushionRange = 0;
    public float FollowIgnoreRange = 3;
    public Vector2 FollowRangeOffset;
    public Vector2 FollowStartRange;
    public Vector2 MaxFollowRange;
    public float MaxSpeed = 5;
    public float MaxAcceleration = 10;
    public BoxCollider2D cushionCollider;
    public Transform followTarget;
    public Vector2 focusPosition;

    Vector2 movePosition;
    Vector2 velocity;

    [SerializeField]
    private Vector2 seperateSpeed;
    [SerializeField]
    private Vector2 followSpeed;

    private void OnEnable()
    {
        cushionCollider = GetComponent<BoxCollider2D>();
        movePosition = transform.position.ToVector2();
    }

    private void Update()
    {
        cushionCollider.size = new Vector2(Camera.ViewportRect.width + 2 * CushionRange, Camera.ViewportRect.height + 2 * CushionRange);
        cushionCollider.offset = Vector2.zero;
        Debug.DrawLine(transform.position, transform.position + seperateSpeed.ToVector3(), Color.blue);
        Debug.DrawLine(transform.position, transform.position + followSpeed.ToVector3(), Color.red);
    }

    public void ResetPosition(Vector2 position)
    {
        movePosition = position;
    }

    public override CameraContext CameraUpdate(CameraContext modifier, float dt)
    {
        if (followTarget)
            focusPosition = followTarget.position;

        var follow = focusPosition - movePosition - FollowRangeOffset;
        var followAccelerateRange = MaxFollowRange - FollowStartRange;

        if (follow.magnitude > FollowIgnoreRange)
        {
            follow.x = Mathf.Clamp01((Mathf.Abs(follow.x) - FollowStartRange.x) / followAccelerateRange.x) * Mathf.Sign(follow.x);
            follow.y = Mathf.Clamp01((Mathf.Abs(follow.y) - FollowStartRange.y) / followAccelerateRange.y) * Mathf.Sign(follow.y);
            followSpeed = follow;
            //followSpeed = follow * MaxSpeed;
            //followSpeed = follow.normalized * Mathf.Clamp01((follow.magnitude - FollowIgnoreRange) / FollowRange) * MaxSpeed;
        }
        var totalVelocity = followSpeed + seperateSpeed;
        if (MathUtility.SignInt(totalVelocity.x) != MathUtility.SignInt(followSpeed.x))
            totalVelocity.x = 0;
        if (MathUtility.SignInt(totalVelocity.y) != MathUtility.SignInt(followSpeed.y))
            totalVelocity.y = 0;

        totalVelocity *= MaxSpeed;
        var dv = totalVelocity - velocity;
        if (dv.magnitude / Time.fixedDeltaTime > MaxAcceleration)
        {
            dv = dv.normalized * MaxAcceleration * Time.fixedDeltaTime;
            totalVelocity = velocity + dv;
        }
        velocity = totalVelocity;
        movePosition += velocity * dt;
        Camera.GetComponent<Rigidbody2D>().MovePosition(movePosition);
        modifier.Position = movePosition;
        return modifier;
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        var seperation = Vector2.zero;
        if (collision.gameObject.layer != 13)
            return;
        for (var i = 0; i < collision.contactCount; i++)
        {
            var contract = collision.GetContact(i);
            if (Mathf.Abs((contract.normal * -contract.separation).x) > Mathf.Abs(seperation.x))
                seperation.x = (contract.normal * -contract.separation).x;
            if (Mathf.Abs((contract.normal * -contract.separation).y) > Mathf.Abs(seperation.y))
                seperation.y = (contract.normal * -contract.separation).y;
        }
        seperation = seperation / CushionRange;
        seperation.x = Mathf.Clamp(seperation.x, -1, 1);
        seperation.y = Mathf.Clamp(seperation.y, -1, 1);


        seperateSpeed = seperation;// * MaxSpeed;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(transform.position + FollowRangeOffset.ToVector3(), FollowStartRange.ToVector3() * 2);
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position + FollowRangeOffset.ToVector3(), MaxFollowRange * 2);
    }
}
