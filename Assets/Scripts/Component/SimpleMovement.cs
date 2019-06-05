using UnityEngine;
using System.Collections;
using System;

[RequireComponent(typeof(Rigidbody2D))]
public class SimpleMovement : MonoBehaviour
{
    public Vector2 Velocity;
    public Vector2 Acceleration;
    public float SpeedIncreasement;
    public bool Moving = false;

    bool controlByCoroutine = false;

    private Vector2 currentVelocity;

    void Start()
    {
        currentVelocity = Velocity;   
    }

    void Update()
    {
        /*var rigidbody = GetComponent<Rigidbody2D>();
        var dv = Velocity - rigidbody.velocity;
        rigidbody.AddForce(dv * rigidbody.mass, ForceMode2D.Impulse);*/
    }

    private void FixedUpdate()
    {
        if (Moving && !controlByCoroutine)
        {
            UpdateVelocity(Time.fixedDeltaTime);
            GetComponent<Rigidbody2D>().velocity = transform.localToWorldMatrix.MultiplyVector(currentVelocity);
        }
    }

    Vector2 UpdateVelocity(float dt)
    {
        currentVelocity += Acceleration * dt;
        var speed = currentVelocity.magnitude;
        speed += SpeedIncreasement * dt;
        speed = speed < 0 ? 0 : speed;
        return currentVelocity = currentVelocity.normalized * speed;
    }

    public void StartMovement()
    {
        Moving = true;
        currentVelocity = Velocity;
        GetComponent<Rigidbody2D>().velocity = transform.localToWorldMatrix.MultiplyVector(currentVelocity);
    }

    public void Stop()
    {
        Moving = false;
        currentVelocity = Vector2.zero;
        GetComponent<Rigidbody2D>().velocity = Vector2.zero;
    }

    public IEnumerator MoveTo(Vector2 position, Func<bool> arrived)
    {
        controlByCoroutine = true;
        GetComponent<Rigidbody2D>().velocity = currentVelocity = Velocity;
        while (!arrived())
        {
            yield return new WaitForFixedUpdate();
            GetComponent<Rigidbody2D>().velocity = UpdateVelocity(Time.fixedDeltaTime);
        }
    }

    public IEnumerator MoveTo(Vector2 position)
    {
        return MoveTo(position, () => (transform.position.ToVector2() - position).magnitude >= GridSystem.Instance.GridPerPixel);
    }
}
