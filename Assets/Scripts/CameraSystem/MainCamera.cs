using UnityEngine;
using System.Collections;
using System.Linq;

public struct CameraContext
{
    public Vector2 Position;
    public Rect ViewPort;
}


public class MainCamera : Singleton<MainCamera>
{
    public Camera Camera;
    public Rect ViewportRect;
    public Vector2 Position => transform.position;

    private void Reset()
    {
        Camera = GetComponent<Camera>();
        var origin = Camera.ViewportToWorldPoint(Vector3.zero);
        var corner = Camera.ViewportToWorldPoint(new Vector3(1, 1, 0));
        ViewportRect = new Rect(Camera.ViewportToWorldPoint(Vector3.zero), corner - origin);
        Debug.DrawLine(Camera.ViewportToWorldPoint(Vector3.zero), Camera.ViewportToWorldPoint(new Vector3(1, 1, 0)));
    }
    private void OnEnable()
    {
        Reset();
    }

    private void Start()
    {
        GameObject.DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        Reset();
    }

    private void FixedUpdate()
    {
        var context = new CameraContext()
        {
            Position = transform.position,
            ViewPort = ViewportRect
        };

        GetComponents<CameraPlugin>()
            .Where(plugin => plugin.Enabled)
            .ForEach(plugin => context = plugin.CameraUpdate(context, Time.fixedDeltaTime));

        GetComponent<Rigidbody2D>().MovePosition(context.Position);
        //GetComponent<Rigidbody2D>().MovePosition(Position);
    }
}
