using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIMask : MonoBehaviour
{
    public void Show(float time = 1)
        => Show(Color.black, time);
    public void Show(Color color, float time = 1)
    {
        color.a = GetComponent<Image>().color.a;
        GetComponent<Image>().color = color;
        StartCoroutine(Utility.ShowUI(GetComponent<Image>(), time));
    }

}
