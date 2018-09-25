using UnityEngine;
using System.Collections;

public class GridSystem : Singleton<GridSystem>
{
    public float PixelPerGrid = 16;
    public float GridPerPixel => 1 / PixelPerGrid;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
