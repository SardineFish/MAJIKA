using UnityEngine;
using System.Collections;

public class PhysicsSystem : Singleton<PhysicsSystem>
{
    public float JumpHeight = 1;
    public float JumpTime = 0.5f;

    public float Gravity => 2 * JumpHeight / Mathf.Pow(JumpTime / 2, 2);
    public float JumpVelocoty => Mathf.Sqrt(2 * Gravity * JumpHeight);
    // Use this for initialization
    void Start()
    {
        Physics2D.gravity = Vector2.down * Gravity;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
