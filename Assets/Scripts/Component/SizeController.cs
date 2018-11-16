using UnityEngine;
using System.Collections;

public enum SizeOption
{
    InScreen,
    FullMap,
    Constant,
}
[ExecuteInEditMode]
public class SizeController : MonoBehaviour
{
    public SizeOption SizeOption = SizeOption.Constant;
    public float Size;
    private void Update()
    {
        if(SizeOption == SizeOption.InScreen)
        {
            var renderer = GetComponentInChildren<SpriteRenderer>();
            var camera = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();
            var origin = camera.ViewportToWorldPoint(Vector3.zero);
            var cameraSize = camera.ViewportToWorldPoint(new Vector3(1, 1, 0)) - origin;
            var dir = transform.localScale.x;
            if (renderer)
            {
                var pos = camera.WorldToScreenPoint(renderer.transform.position);
                float size;
                if (dir > 0)
                    size = Mathf.Abs(renderer.transform.position.x - origin.x - cameraSize.x);
                else
                    size = Mathf.Abs(renderer.transform.position.x - origin.x);
                renderer.size = new Vector2(size, renderer.size.y);
            }
            var collider = GetComponentInChildren<BoxCollider2D>();
            if (collider)
            {
                var left = collider.offset.x - collider.size.x / 2;
                var right = collider.offset.x + collider.size.x / 2;
                var localCameraOrigin = collider.transform.worldToLocalMatrix.MultiplyPoint(origin);
                var localCameraSize = collider.transform.worldToLocalMatrix.MultiplyVector(cameraSize);
                if (dir > 0)
                    right = localCameraOrigin.x + localCameraSize.x;
                else
                    right = localCameraOrigin.x;
                collider.offset = new Vector2((left + right) / 2, collider.offset.y);
                collider.size = new Vector2(right - left, collider.size.y);
            }
        }
    }
}
