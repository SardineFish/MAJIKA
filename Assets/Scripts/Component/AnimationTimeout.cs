using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Animator))]
public class AnimationTimeout : MonoBehaviour
{
    public float Time;
    public string AnimatorTrigger = "";

    IEnumerator TimerCoroutine()
    {
        yield return new WaitForSeconds(Time);
        GetComponent<Animator>().SetTrigger(AnimatorTrigger);
    }
    public void StartTimer()
    {
        StartCoroutine(TimerCoroutine());
    }
}
