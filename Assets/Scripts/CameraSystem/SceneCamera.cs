using UnityEngine;
using System.Collections;
using System.Linq;

public struct CameraContext
{
    public Vector2 Position;
    public Rect ViewPort;
}

[ExecuteInEditMode]
[RequireComponent(typeof(Rigidbody2D))]
public class SceneCamera : Singleton<SceneCamera>
{
    public Camera Camera;
    public Rect ViewportRect;
    public Vector2 Position => transform.position;

    private void Reset()
    {
        Camera = GameObject.FindGameObjectWithTag("MainCamera")?.GetComponent<Camera>();
        UpdateViewPort();
    }
    private void OnEnable()
    {
        Reset();
        
    }

    private void Start()
    {
        Camera.transform.position = transform.position;
    }

    private void Update()
    {
        if (!Camera)
            return;
        UpdateViewPort();
        if(!Application.isPlaying)
        {
            Camera.transform.position = transform.position;
        }
    }

    private void FixedUpdate()
    {
        if(!Application.isPlaying)
        {
            return;
        }
        var context = new CameraContext()
        {
            Position = transform.position,
            ViewPort = ViewportRect
        };

        GetComponents<CameraPlugin>()
            .Where(plugin => plugin.Enabled)
            .ForEach(plugin => context = plugin.CameraUpdate(context, Time.fixedDeltaTime));

        GetComponent<Rigidbody2D>().MovePosition(context.Position);
        Camera.transform.position = transform.position;
        //GetComponent<Rigidbody2D>().MovePosition(Position);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawWireCube(transform.position, ViewportRect.size);
    }

    void UpdateViewPort()
    {
        if (!Camera)
            return;
        var origin = Camera.ViewportToWorldPoint(Vector3.zero);
        var corner = Camera.ViewportToWorldPoint(new Vector3(1, 1, 0));
        ViewportRect = new Rect(Camera.ViewportToWorldPoint(Vector3.zero), corner - origin);
        Debug.DrawLine(Camera.ViewportToWorldPoint(Vector3.zero), Camera.ViewportToWorldPoint(new Vector3(1, 1, 0)));
    }
}
