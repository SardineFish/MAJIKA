using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class SceneDepth: MonoBehaviour
{
    public Vector2 InitialPosition;
    public bool UsePosZ = true;
    public float Depth = 0;
    public SceneCamera Camera;

    private void Reset()
    {
        InitialPosition = transform.position;
        Camera = SceneCamera.Instance;
    }

    private void OnEnable()
    {
        Camera = SceneCamera.Instance;
    }

    private void Update()
    {
        if (UsePosZ)
            Depth = transform.position.z;
        var cameraDelta = Camera.GetComponent<DepthOfField>().ScaledDelta;
        var factor = Camera.GetComponent<DepthOfField>().DepthFactor;
        transform.position = (cameraDelta * (Depth * factor) + InitialPosition).ToVector3(transform.position.z);
    }
}