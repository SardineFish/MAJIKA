using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[ExecuteInEditMode]
public class ValueBar : MonoBehaviour
{
    [Range(0, 1)]
    public float NormalizedValue;
    public BoxOffset Margin;

    void LateUpdate()
    {
        var bar = transform.Find("Bar").gameObject;
        var wrapper = GetComponent<RectTransform>();
        var w = wrapper.rect.width - (Margin.left + Margin.right);
        var right = -(w * (1 - NormalizedValue) + Margin.right);
        bar.GetComponent<RectTransform>().offsetMax = new Vector2(right, bar.GetComponent<RectTransform>().offsetMax.y);

    }
}
