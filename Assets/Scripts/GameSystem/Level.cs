using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using MAJIKA.GUI;

public class Level : Singleton<Level>
{
    public const string EventFailed = "Failed";
    public const string EventPass = "Pass";
    public CoveredUI PassUI;
    public CoveredUI FailedUI;
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
        PassUI?.Show();
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
        FailedUI?.Show();
        var animator = FailedUI.GetComponent<Animator>();
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
