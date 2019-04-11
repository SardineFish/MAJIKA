using UnityEngine;
using System.Collections;

public class Focusable : MonoBehaviour
{
    public void Focus()
    {
        GetComponent<Animator>()?.SetTrigger("focus");
    }

    public void Unfocus()
    {
        GetComponent<Animator>()?.SetTrigger("unfocus");
    }
}
