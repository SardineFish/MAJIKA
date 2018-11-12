using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
public class SimpleMovement : MonoBehaviour
{
    public Vector2 Velocity;
    public Vector2 Acceleration;
    public float SpeedIncreasement;
    public bool Moving = false;

    private Vector2 currentVelocity;

    void Update()
    {
        /*var rigidbody = GetComponent<Rigidbody2D>();
        var dv = Velocity - rigidbody.velocity;
        rigidbody.AddForce(dv * rigidbody.mass, ForceMode2D.Impulse);*/
    }

    private void FixedUpdate()
    {
        if (Moving)
        {
            currentVelocity += Acceleration * Time.fixedDeltaTime;
            var speed = currentVelocity.magnitude;
            speed += SpeedIncreasement * Time.fixedDeltaTime;
            speed = speed < 0 ? 0 : speed;
            currentVelocity = currentVelocity.normalized * speed;
            GetComponent<Rigidbody2D>().velocity = transform.localToWorldMatrix.MultiplyVector(currentVelocity);
        }
    }

    public void StartMovement()
    {
        Moving = true;
        currentVelocity = Velocity;
        GetComponent<Rigidbody2D>().velocity = transform.localToWorldMatrix.MultiplyVector(currentVelocity);
    }
}
