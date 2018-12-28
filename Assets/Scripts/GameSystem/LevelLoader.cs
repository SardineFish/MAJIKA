using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelLoader : Singleton<LevelLoader>
{
    public GameObject LoadingUI;
    public IEnumerator LoadLevelWithoutUI(string scenePath)
    {
        yield return SceneManager.LoadSceneAsync(scenePath, LoadSceneMode.Single);
    }
    public IEnumerator LoadLevel(string scenePath)
    {
        yield return Utility.ShowUI(LoadingUI.GetComponent<UnityEngine.UI.Graphic>(), 1f);
        yield return SceneManager.LoadSceneAsync(scenePath, LoadSceneMode.Single);
        yield return Utility.HideUI(LoadingUI.GetComponent<UnityEngine.UI.Graphic>(), 1f);
        FindObjectOfType<Level>().Ready();
    }
    public void LoadLevelDetach(string scenePath)
    {
        StartCoroutine(LoadLevel(scenePath));
    }
}
