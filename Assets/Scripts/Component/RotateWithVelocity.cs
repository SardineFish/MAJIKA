using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
public class RotateWithVelocity : MonoBehaviour
{

    public Transform Target;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (!Target)
            return;
        Target.transform.eulerAngles = Target.transform.rotation.eulerAngles.Set(z: Vector2.SignedAngle(Vector2.right, GetComponent<Rigidbody2D>().velocity.normalized));
    }
}
