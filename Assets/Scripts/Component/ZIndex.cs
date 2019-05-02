using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class ZIndex : MonoBehaviour
{
    public float zIndex = 0;
    public bool Local = false;
    // Update is called once per frame
    void Update()
    {
        if (Local)
            transform.localPosition = transform.localPosition.Set(z: zIndex);
        else
            transform.position = transform.position.Set(z: zIndex);
    }
}
