using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Animator))]
public class AnimatorTrigger : MonoBehaviour
{
    public string Trigger;
    public void SetTrigger()
    {
        GetComponent<Animator>().SetTrigger(Trigger);
    }
}
