using UnityEngine;
using System.Collections;
public enum SnapMode
{
    None,
    SnapToPixel,
    SnapToGrid
}
public class GridSnapper : MonoBehaviour
{
    public SnapMode SnapMode = SnapMode.SnapToPixel;
    public Vector3 OriginOffset;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
