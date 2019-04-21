using UnityEngine;
using System.Collections;

public class RuntimeLayer : MonoBehaviour
{
    
    public int Layer;
    private void OnEnable()
    {
        Layer = gameObject.layer;
    }

    private void Update()
    {
        gameObject.layer = Layer;
    }
}
