using UnityEngine;
using System.Collections;

public enum ChaseType
{
    Force,
    Steering,
}
[RequireComponent(typeof(Rigidbody2D))]
public class ChaseObject : MonoBehaviour
{
    public Transform Target;
    public ChaseType ChaseType;
    public float MaxForce;
    public float MaxSpeed;
    public float MaxAngularSpeed;
    Vector2 velocity;

    // Use this for initialization
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = transform.right * MaxSpeed;
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void FixedUpdate()
    {
        if (!Target)
            return;
        var rigidbody = GetComponent<Rigidbody2D>();
        var dir = (Target.position - transform.position).normalized;
        if (ChaseType == ChaseType.Force)
        {
            rigidbody.AddForce(dir * MaxForce, ForceMode2D.Force);

            var ang = Vector2.SignedAngle(velocity.normalized, rigidbody.velocity.normalized);
            ang = Mathf.Clamp(ang, -MaxAngularSpeed * Time.deltaTime, MaxAngularSpeed * Time.deltaTime);
            rigidbody.velocity = rigidbody.velocity.magnitude * MathUtility.Rotate(rigidbody.velocity.normalized, ang * Mathf.Deg2Rad);
            velocity = rigidbody.velocity;
        }
        else if (ChaseType == ChaseType.Steering)
        {
            var ang = Vector2.SignedAngle(rigidbody.velocity.normalized, dir);
            ang = Mathf.Clamp(ang, -MaxAngularSpeed * Time.deltaTime, MaxAngularSpeed * Time.deltaTime);
            rigidbody.velocity = MaxSpeed * MathUtility.Rotate(rigidbody.velocity.normalized, ang * Mathf.Deg2Rad);
        }
        rigidbody.velocity = rigidbody.velocity.normalized * Mathf.Clamp(rigidbody.velocity.magnitude, 0, MaxSpeed);
    }
}
