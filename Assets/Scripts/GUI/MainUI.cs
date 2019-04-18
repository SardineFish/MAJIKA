using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class MainUI : Singleton<MainUI>
{

    // Update is called once per frame
    void Update()
    {
        if (NewInputManager.Instance.Controller.Actions.AnyKey.WasPressedThisFrame())
        {
            GetComponent<Animator>().SetTrigger("start");
        }
    }

    public void ReStart()
    {
        GetComponent<Animator>().SetTrigger("restart");
    }

    public void EnterGame()
    {
        StartCoroutine(EnterGameCoroutine());
    }

    IEnumerator EnterGameCoroutine()
    {
        yield return LevelLoader.Instance.LoadLevelWithoutUI(GameSystem.Instance.TutorialScenePath);
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
