using UnityEngine;
using System.Collections;

public class GridSystem : Singleton<GridSystem>
{
    public float PixelPerGrid = 16;
    public float GridPerPixel => 1 / PixelPerGrid;
    public float ScreenPixelPerUnit = 4;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
