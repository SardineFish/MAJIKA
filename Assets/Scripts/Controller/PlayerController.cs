using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float Speed = 1f;
    public int MaxJumpCount = 2;
    public float OnGroundThreshold = 0.01f;
    int jumpCount = 0;

	// Use this for initialization
	void Start () {
        jumpCount = MaxJumpCount;
	}
	
	// Update is called once per frame
	void Update () {
        var movement = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        //gameObject.transform.Translate(Speed * movement * Time.deltaTime);
        var velocity = GetComponent<Rigidbody2D>().velocity;
        velocity.x = movement.x * Speed;
        //GetComponent<Rigidbody2D>().MovePosition(transform.position + Speed * movement * Time.deltaTime);
        if (Input.GetKeyDown(InputManager.Instance.KeyJump))
        {
            if (jumpCount-- > 0)
            {
                Debug.Log("Jump");
                velocity.y = PhysicsSystem.Instance.JumpVelocoty;
            }
        }
        GetComponent<Rigidbody2D>().velocity = velocity;
    }

    private void FixedUpdate()
    {
        var rigidbody = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        for (int i = 0; i < collision.contactCount; i++)
        {
            var contract = collision.GetContact(i);
            var localPoint = transform.worldToLocalMatrix.MultiplyPoint(contract.point);
            Debug.Log(localPoint.y);
            if (Mathf.Abs(localPoint.y) <= OnGroundThreshold)
                jumpCount = MaxJumpCount;
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        for (int i = 0; i < collision.contactCount; i++)
        {
            var contract = collision.GetContact(i);
            Debug.DrawLine(transform.position, contract.point, Color.blue);
        }
    }
}
