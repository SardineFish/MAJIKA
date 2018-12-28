using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Tips : Singleton<Tips>
{
    public Text Text;
    public void ShowTips(string tip, float time)
    {
        StartCoroutine(ShowTipsWait(tip, time));
    }
    public IEnumerator ShowTipsWait(string tip, float time)
    {
        yield return Utility.ShowUI(GetComponent<Graphic>(), .2f, .4f);
        Text.text = tip;
        yield return Utility.ShowUI(Text, .3f);
        yield return new WaitForSeconds(time - 1);
        yield return Utility.HideUI(Text, .2f);
        /*
        var color = Text.color;
        color.a = 0;
        Text.color = color;
        gameObject.SetActive(true);
        Text.text = tip;
        foreach (var t in Utility.TimerNormalized(0.5f))
        {
            color.a = t;
            Text.color = color;
            yield return null;
        }
        yield return new WaitForSeconds(time - 1);
        foreach (var t in Utility.TimerNormalized(0.5f))
        {
            color.a = 1 - t;
            Text.color = color;
            yield return null;
        }*/
        yield return Utility.HideUI(GetComponent<Graphic>(), .2f);
    }
}
