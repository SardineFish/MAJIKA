using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using MAJIKA.GUI;

public class LevelLoader : Singleton<LevelLoader>
{
    public CoveredUI LoadingUI;
    public IEnumerator LoadLevelWithoutUI(string scenePath)
    {
        yield return SceneManager.LoadSceneAsync(scenePath, LoadSceneMode.Single);
    }
    public IEnumerator LoadLevel(string scenePath)
    {
        yield return LoadingUI.Show(.5f);
        yield return SceneManager.LoadSceneAsync(scenePath, LoadSceneMode.Single);
        yield return LoadingUI.Hide(1);
        FindObjectOfType<Level>().Ready();
    }
    public void LoadLevelDetach(string scenePath)
    {
        StartCoroutine(LoadLevel(scenePath));
    }
}
