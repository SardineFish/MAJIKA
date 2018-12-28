using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[ExecuteInEditMode]
public class ValueBar : MonoBehaviour
{
    [Range(0, 1)]
    public float NormalizedValue;
    public BoxOffset Margin;
    public float DelayTime;

    float lastValue = 0;

    void LateUpdate()
    {
        NormalizedValue = Mathf.Clamp01(NormalizedValue);
        var bar = transform.Find("Bar").gameObject;
        var bg = transform.Find("Backgound")?.gameObject;
        SetValue(bar, NormalizedValue);
        if (lastValue != NormalizedValue)
        {
            StopAllCoroutines();
            if (bg)
                StartCoroutine(DelayAdjust(bg, DelayTime, lastValue, NormalizedValue));
        }
        lastValue = NormalizedValue;

    }

    IEnumerator DelayAdjust(GameObject bar, float time, float from, float to)
    {
        yield return new WaitForSeconds(time);
        var dv = to - from;
        foreach(var t in Utility.TimerNormalized(.5f))
        {
            SetValue(bar, dv * t + from);
            yield return null;
        }
    }

    void SetValue(GameObject bar, float value)
    {
        var wrapper = GetComponent<RectTransform>();
        var w = wrapper.rect.width - (Margin.left + Margin.right);
        var right = -(w * (1 - value) + Margin.right);
        bar.GetComponent<RectTransform>().offsetMax = new Vector2(right, bar.GetComponent<RectTransform>().offsetMax.y);
    }
}
