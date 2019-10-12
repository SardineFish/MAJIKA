using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MAJIKA.GUI;
using System;

public enum LevelState
{
    Play,
    Failed,
    Pass,
}
[RequireComponent(typeof(EventBus))]
[RequireComponent(typeof(LevelAssetLoader))]
[RequireComponent(typeof(AudioController))]
public class Level : Singleton<Level>
{
    public const string EventFailed = "Failed";
    public const string EventPass = "Pass";
    public LevelState LevelState = LevelState.Play;
    public string PassUIName = "LevelPass";
    public string FailedUIName = "LevelFailed";
    public string NextScene;
    public List<MonoBehaviour> ActiveAtLoaded = new List<MonoBehaviour>();
    public event Action OnLevelReady;

    protected void Awake()
    {
        LevelState = LevelState.Play;
        GetComponent<EventBus>().On(EventFailed, () => StartCoroutine(OnLevelFailed()));
        GetComponent<EventBus>().On(EventPass, () => StartCoroutine(OnLevelPass()));
    }
    IEnumerator OnLevelPass()
    {
        if (LevelState != LevelState.Play)
            yield break;
            
        LevelState = LevelState.Pass;
        Debug.Log("Level Pass.");
        StopEverything();

        CoveredUI.Find(PassUIName)?.ShowAsync();
        var animator = CoveredUI.Find(PassUIName)?.GetComponent<Animator>();
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
        if (LevelState != LevelState.Play)
            yield break;
        LevelState = LevelState.Failed;
        Debug.Log("Game Over.");
        StopEverything();

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

    void StopEverything()
    {
        CoveredUI.Find("GameUI")?.HideAsync();
        CoveredUI.Find("TouchController")?.HideAsync();
        CoveredUI.Find("Tips")?.HideAsync();
        return;
        EntityManager.FindEntities<GameEntity>()
            .Where(entity => entity)
            .ForEach(entity => entity.SetActive(false));
    }
    public void Ready()
    {
        OnLevelReady?.Invoke();
        this.SetTimeout(() => ActiveAtLoaded.ForEach(cpn => cpn.enabled = true), 0.5f);
        CoveredUI.Find("GameUI").ShowAsync();
        ActiveAtLoaded.ForEach(cpn => cpn.enabled = true);
        LevelLoader.Instance.CompleteLoading();
    }
}
