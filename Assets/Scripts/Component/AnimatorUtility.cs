using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Animator))]
public class AnimatorUtility : MonoBehaviour
{
    public bool AutoDestroy = true;
    private void Update()
    {
        if (GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).normalizedTime > 1)
            Destroy(gameObject);
    }
}
