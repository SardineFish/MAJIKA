using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[ExecuteInEditMode]
public class UITransparent : MonoBehaviour
{
    [Range(0,1)]
    public float opacity = 1;
    private void Update()
    {
        GetComponent<Graphic>().color = GetComponent<Graphic>().color.Set(a: opacity);
        GetComponentsInChildren<Graphic>().ForEach(g => g.color = g.color.Set(a: opacity));
    }
}
