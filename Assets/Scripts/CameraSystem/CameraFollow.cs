using UnityEngine;
using System.Collections;
using System.Linq;

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
    [SerializeField]
    private Transform followTarget;
    public Vector2 focusPosition;

    Vector2 movePosition;
    Vector2 velocity;
    Transform[] multiFollow = new Transform[] { };

    [SerializeField]
    private Vector2 seperate;
    [SerializeField]
    private Vector2 followSpeed;

    private void OnEnable()
    {
        cushionCollider = GetComponent<BoxCollider2D>();
        movePosition = transform.position.ToVector2();
        if (followTarget)
            multiFollow = new Transform[] { followTarget };
    }

    private void Update()
    {
        cushionCollider.size = new Vector2(Camera.ViewportRect.width + 2 * CushionRange, Camera.ViewportRect.height + 2 * CushionRange);
        cushionCollider.offset = Vector2.zero;
        Debug.DrawLine(transform.position, transform.position + seperate.ToVector3(), Color.blue);
        Debug.DrawLine(transform.position, transform.position + followSpeed.ToVector3(), Color.red);
    }

    public void Follow(params Transform[] targets)
    {
        if (targets.Length == 1)
            followTarget = targets[0];
        multiFollow = targets;
    }

    public void ResetPosition(Vector2 position)
    {
        movePosition = position;
    }

    public override CameraContext CameraUpdate(CameraContext modifier, float dt)
    {
        multiFollow = multiFollow.Where(f => f).ToArray();
        if (multiFollow.Length > 0)
        {
            focusPosition = multiFollow.Sum(target => target.transform.position.ToVector2()) / multiFollow.Length;
            if (multiFollow.Length > 1)
            {
                var screenSpacePos = (multiFollow[0].transform.position.ToVector2() - focusPosition);
                screenSpacePos = screenSpacePos / (Camera.ViewportRect.size / 2);
                if (screenSpacePos.magnitude > 0.9f)
                    screenSpacePos = screenSpacePos.normalized * 0.9f;
                var pos = screenSpacePos * (Camera.ViewportRect.size / 2);
                focusPosition = multiFollow[0].transform.position.ToVector2() - pos;
            }
        }
        else
        {
            focusPosition = transform.position;
        }
        Debug.DrawLine(transform.position, focusPosition, Color.green);

        var follow = focusPosition - movePosition - FollowRangeOffset;
        var followAccelerateRange = MaxFollowRange - FollowStartRange;

        if (follow.magnitude > FollowIgnoreRange)
        {
            follow.x = Mathf.Clamp01((Mathf.Abs(follow.x) - FollowStartRange.x) / followAccelerateRange.x) * Mathf.Sign(follow.x);
            follow.y = Mathf.Clamp01((Mathf.Abs(follow.y) - FollowStartRange.y) / followAccelerateRange.y) * Mathf.Sign(follow.y);
            this.followSpeed = follow;
            //followSpeed = follow * MaxSpeed;
            //followSpeed = follow.normalized * Mathf.Clamp01((follow.magnitude - FollowIgnoreRange) / FollowRange) * MaxSpeed;
        }

        followSpeed *= MaxSpeed;
        var dv = followSpeed - velocity;
        if (dv.magnitude / Time.fixedDeltaTime > MaxAcceleration)
        {
            dv = dv.normalized * MaxAcceleration * Time.fixedDeltaTime;
            followSpeed = velocity + dv;
        }
        
        followSpeed.x *= Mathf.Clamp01(1 + Mathf.Pow(seperate.x, 5) * MathUtility.SignInt(followSpeed.x));
        followSpeed.y *= Mathf.Clamp01(1 + Mathf.Pow(seperate.y, 5) * MathUtility.SignInt(followSpeed.y));

        velocity = followSpeed;
        movePosition += velocity * dt;
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


        seperate = seperation;// * MaxSpeed;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(transform.position + FollowRangeOffset.ToVector3(), FollowStartRange.ToVector3() * 2);
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position + FollowRangeOffset.ToVector3(), MaxFollowRange * 2);
    }
}
