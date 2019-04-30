using UnityEngine;
using System.Collections;

[RequireComponent(typeof(SceneCamera))]
public class DepthOfField : CameraPlugin
{
    public Vector2 BasePosition;
    public float Scale = 1;
    public float DepthFactor = 0.1f;

    public Vector2 Delta => transform.position.ToVector2() - BasePosition;
    public Vector2 ScaledDelta => Delta * Scale;

    public void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.magenta;
        Gizmos.DrawWireSphere(BasePosition, 1);
    }
}
