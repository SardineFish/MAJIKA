using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
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
        yield return LevelLoader.LoadLevel(GameSystem.Instance.TutorialScenePath);
        GetComponent<Animator>().SetTrigger("hide");
        yield return null;
        var animator = GetComponent<Animator>();
        while(animator.GetCurrentAnimatorStateInfo(0).normalizedTime < 1)
        {
            yield return null;
        }
        FindObjectOfType<Level>().Ready();
    }
}
