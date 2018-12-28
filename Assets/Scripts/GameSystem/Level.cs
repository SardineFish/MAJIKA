using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Level : Singleton<Level>
{
    public const string EventFailed = "Failed";
    public const string EventPass = "Pass";
    public GameObject PassUI;
    public GameObject FailUI;
    public string NextScene;
    public List<MonoBehaviour> ActiveAtLoaded = new List<MonoBehaviour>();
    protected override void Awake()
    {
        base.Awake();
        GetComponent<EventBus>().On(EventFailed, () => StartCoroutine(OnLevelFailed()));
        GetComponent<EventBus>().On(EventPass, () => StartCoroutine(OnLevelPass()));
    }
    IEnumerator OnLevelPass()
    {
        PassUI?.SetActive(true);
        var animator = PassUI.GetComponent<Animator>();
        yield return null;
        while (animator.GetCurrentAnimatorStateInfo(0).normalizedTime < 1)
            yield return null;
        yield return InputManager.Instance.WaitForAction(InputManager.Instance.AcceptAction);
        animator.SetTrigger("exit");
        yield return null;
        while (animator.GetCurrentAnimatorStateInfo(0).normalizedTime < 1)
            yield return null;
        LevelLoader.Instance.LoadLevelDetach(NextScene);
    }
    IEnumerator OnLevelFailed()
    {
        FailUI?.SetActive(true);
        var animator = FailUI.GetComponent<Animator>();
        yield return null;
        while (animator.GetCurrentAnimatorStateInfo(0).normalizedTime < 1)
            yield return null;
        yield return InputManager.Instance.WaitForAction(InputManager.Instance.AcceptAction);
        animator.SetTrigger("exit");

        while (animator.GetCurrentAnimatorStateInfo(0).normalizedTime < 1)
            yield return null;
        LevelLoader.Instance.LoadLevelDetach(gameObject.scene.path);
    }
    public void Ready()
    {
        ActiveAtLoaded.ForEach(cpn => cpn.enabled = true);
    }
}
