using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float Speed = 1f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var movement = new Vector2(Input.GetAxis("Horizontal"), 0);
        gameObject.transform.Translate(Speed * movement * Time.deltaTime);
        if (Input.GetKeyDown(InputManager.Instance.KeyJump))
        {
            Debug.Log("Jump");
            GetComponent<Rigidbody2D>().velocity = Vector2.up * PhysicsSystem.Instance.JumpVelocoty;
        }
	}

    private void FixedUpdate()
    {
        var rigidbody = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
}
