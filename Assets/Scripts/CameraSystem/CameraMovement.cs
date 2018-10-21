using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
[RequireComponent(typeof(Rigidbody2D), typeof(BoxCollider2D))]
public class CameraMovement : MonoBehaviour
{
    public new Camera camera;
    public Rect ViewportRect;
    public bool EnableFollow = true;
    public float CushionRange = 0;
    public float FollowIgnoreRange = 3;
    public float FollowRange = 5;
    public float MaxSpeed = 5;
    public BoxCollider2D cushionCollider;
    public Transform followTarget;

    private Vector2 seperateSpeed;
    private Vector2 followSpeed;

    // Use this for initialization
    void Start()
    {
        camera = GetComponent<Camera>();
        cushionCollider = GetComponent<BoxCollider2D>();
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
        var follow = (followTarget.position - transform.position).ToVector2();
        if (follow.magnitude < FollowIgnoreRange)
            follow = Vector2.zero;
        follow /= FollowRange;
        follow = Vector2.ClampMagnitude(follow, 1);
        followSpeed = follow * MaxSpeed;
        if (EnableFollow)
            GetComponent<Rigidbody2D>().velocity = followSpeed + seperateSpeed;
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
        Debug.DrawLine(transform.position, transform.position + seperation.ToVector3(), Color.green);
        seperation = Vector2.ClampMagnitude(seperation / CushionRange, 1);
        Debug.DrawLine(transform.position, transform.position + seperation.ToVector3(), Color.cyan);

        seperateSpeed = seperation * MaxSpeed;
        Debug.DrawLine(transform.position, transform.position + seperateSpeed.ToVector3(), Color.magenta);
    }
}
