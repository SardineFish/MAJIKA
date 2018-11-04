using UnityEngine;
using System.Collections;

public class ZIndex : MonoBehaviour
{
    public float zIndex = 0;
    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position.Set(z: zIndex);
    }
}
