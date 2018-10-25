using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
public class SimpleMovement : MonoBehaviour
{
    public Vector2 Velocity;

    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = Velocity;
    }
}
