using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
public class MainUI : Singleton<MainUI>, IPointerClickHandler
{

    // Update is called once per frame
    void Update()
    {
        if (InputManager.Instance.Controller.Actions.AnyKey.WasPressedThisFrame())
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
        yield return new WaitForSeconds(1);
        var animator = GetComponent<Animator>();
        while(animator.GetCurrentAnimatorStateInfo(0).normalizedTime < 1)
        {
            yield return null;
        }
        FindObjectOfType<Level>().Ready();
        gameObject.SetActive(false);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        GetComponent<Animator>().SetTrigger("start");
    }
}
