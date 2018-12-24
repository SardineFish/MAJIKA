using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D), typeof(BoxCollider2D))]
public class CameraMovement : MonoBehaviour
{
    public new Camera camera;
    public Rect ViewportRect;
    public bool EnableFollow = true;
    public float CushionRange = 0;
    public float FollowIgnoreRange = 3;
    public Vector2 FollowRangeOffset;
    public Vector2 FollowStartRange;
    public Vector2 MaxFollowRange;
    public float MaxSpeed = 5;
    public float MaxAcceleration = 10;
    public BoxCollider2D cushionCollider;
    public Transform followTarget;
    public Vector3 focusPosition;

    private Vector2 seperateSpeed;
    private Vector2 followSpeed;

    // Use this for initialization
    void Start()
    {
        camera = GetComponent<Camera>();
        cushionCollider = GetComponent<BoxCollider2D>();
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        camera = GetComponent<Camera>();
        cushionCollider = GetComponent<BoxCollider2D>();
        //Debug.DrawLine(camera.cameraToWorldMatrix.MultiplyPoint(Vector3.zero), camera.cameraToWorldMatrix.MultiplyPoint(new Vector3(1, 1, 0)*camera.orthographicSize));
        Debug.DrawLine(camera.ViewportToWorldPoint(Vector3.zero), camera.ViewportToWorldPoint(new Vector3(1, 1, 0)));
        var origin = camera.ViewportToWorldPoint(Vector3.zero);
        var corner = camera.ViewportToWorldPoint(new Vector3(1, 1, 0));
        ViewportRect = new Rect(camera.ViewportToWorldPoint(Vector3.zero), corner - origin);
        cushionCollider.size = new Vector2(ViewportRect.width + 2 * CushionRange, ViewportRect.height + 2 * CushionRange);
        cushionCollider.offset = Vector2.zero;
        Debug.DrawLine(transform.position, transform.position + seperateSpeed.ToVector3(), Color.blue);
        Debug.DrawLine(transform.position, transform.position + followSpeed.ToVector3(), Color.red);
    }

    private void FixedUpdate()
    {
        if (followTarget)
            focusPosition = followTarget.position;

        var follow = (focusPosition - transform.position - FollowRangeOffset.ToVector3()).ToVector2();
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

        if (EnableFollow)
        {
            totalVelocity *= MaxSpeed;
            var dv = totalVelocity - GetComponent<Rigidbody2D>().velocity;
            if (dv.magnitude / Time.fixedDeltaTime > MaxAcceleration)
            {
                dv = dv.normalized * MaxAcceleration * Time.fixedDeltaTime;
                totalVelocity = GetComponent<Rigidbody2D>().velocity + dv;
            }
            GetComponent<Rigidbody2D>().velocity = totalVelocity;
        }
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
