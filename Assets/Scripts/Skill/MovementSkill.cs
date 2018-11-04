using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class MovementSkill : MonoBehaviour
{
    public float Distance = 3;
    public float Duration = 0.1f;
    public Vector2 Direction = Vector2.right;
    public float Speed => Distance / Duration;
}
