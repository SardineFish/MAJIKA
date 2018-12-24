using UnityEngine;
using System.Collections;

public class MainUI : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (InputManager.Instance.GetAction(InputManager.Instance.AnyKey))
        {
            GetComponent<Animator>().SetTrigger("start");
        }
    }

    public void EnterGame()
    {
        StartCoroutine(EnterGameCoroutine());
    }

    IEnumerator EnterGameCoroutine()
    {
        yield break;
    }
}
