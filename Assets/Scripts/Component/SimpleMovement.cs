using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
public class SimpleMovement : MonoBehaviour
{
    public Vector2 Velocity;

    void Update()
    {
        /*var rigidbody = GetComponent<Rigidbody2D>();
        var dv = Velocity - rigidbody.velocity;
        rigidbody.AddForce(dv * rigidbody.mass, ForceMode2D.Impulse);*/
        GetComponent<Rigidbody2D>().velocity = transform.localToWorldMatrix.MultiplyVector(Velocity);
    }
}
