using UnityEngine;
using System.Collections;

[RequireComponent(typeof(EventBus))]
public class OutScreenDestruct : MonoBehaviour
{
    public Vector2 Offset;
    public float Radus = 1;
    public string EventDestruct = "Destruct";
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!Physics2D.OverlapCircle(transform.position.ToVector2() + Offset, Radus, 1 << 12))
        {
            GetComponent<EventBus>().Dispatch(EventDestruct);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.magenta;
        Gizmos.DrawWireSphere(transform.position + Offset.ToVector3(), Radus);
    }
}
