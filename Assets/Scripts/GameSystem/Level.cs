using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using MAJIKA.GUI;

[RequireComponent(typeof(EventBus))]
public class Level : Singleton<Level>
{
    public const string EventFailed = "Failed";
    public const string EventPass = "Pass";
    public string PassUIName = "LevelPass";
    public string FailedUIName = "LevelFailed";
    public string NextScene;
    public List<MonoBehaviour> ActiveAtLoaded = new List<MonoBehaviour>();
    protected void Awake()
    {
        GetComponent<EventBus>().On(EventFailed, () => StartCoroutine(OnLevelFailed()));
        GetComponent<EventBus>().On(EventPass, () => StartCoroutine(OnLevelPass()));
    }
    IEnumerator OnLevelPass()
    {
        CoveredUI.Find(PassUIName)?.ShowAsync();
        var animator = CoveredUI.Find(FailedUIName)?.GetComponent<Animator>();
        yield return null;
        while (animator.GetCurrentAnimatorStateInfo(0).normalizedTime < 1)
            yield return null;
        //yield return InputManager.Instance.Controller.Actions.Accept.WaitPerform();
        while (!InputManager.Instance.Actions.Accept.WasPressedThisFrame() && !InputManager.Instance.GetTouch())
            yield return null;
        animator.SetTrigger("exit");
        yield return null;
        while (animator.GetCurrentAnimatorStateInfo(0).normalizedTime < 1)
            yield return null;
        LevelLoader.Instance.LoadLevelDetach(NextScene);
    }
    IEnumerator OnLevelFailed()
    {
        CoveredUI.Find(FailedUIName)?.ShowAsync();
        var animator = CoveredUI.Find(FailedUIName)?.GetComponent<Animator>();
        yield return null;
        while (animator.GetCurrentAnimatorStateInfo(0).normalizedTime < 1)
            yield return null;
        //yield return InputManager.Instance.Controller.Actions.Accept.WaitPerform();
        while (!InputManager.Instance.Actions.Accept.WasPressedThisFrame() && !InputManager.Instance.GetTouch())
            yield return null;
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
