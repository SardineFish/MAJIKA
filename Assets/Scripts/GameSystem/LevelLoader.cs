using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using MAJIKA.GUI;

public class LevelLoader : Singleton<LevelLoader>
{
    public IEnumerator LoadLevelWithoutUI(string scenePath)
    {
        yield return SceneManager.LoadSceneAsync(scenePath, LoadSceneMode.Single);
    }
    public IEnumerator LoadLevel(string scenePath)
    {
        yield return LoadingUI.Instance.Show(.5f);
        Debug.Log(scenePath);
        yield return SceneManager.LoadSceneAsync(scenePath, LoadSceneMode.Single);
    }
    public void CompleteLoading()
    {
        LoadingUI.Instance.HideAsync(.5f);
    }
    public void LoadLevelDetach(string scenePath)
    {
        StartCoroutine(LoadLevel(scenePath));
    }
}
