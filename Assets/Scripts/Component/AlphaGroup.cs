using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class AlphaGroup : MonoBehaviour
{
    [Range(0, 1)]
    public float Alpha = 1;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GetComponentsInChildren<SpriteRenderer>().ForEach(renderer =>
        {
            var color = renderer.color;
            color.a = Alpha;
            renderer.color = color;
        });
    }

    private void UpdateAlpha()
    {
    }
}
