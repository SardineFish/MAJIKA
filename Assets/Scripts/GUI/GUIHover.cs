using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Canvas))]
public class GUIHover : EntityBehaviour
{
    private void OnEnable()
    {
        var canvas = GetComponent<Canvas>();
        if (canvas)
            canvas.worldCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();

    }
}
