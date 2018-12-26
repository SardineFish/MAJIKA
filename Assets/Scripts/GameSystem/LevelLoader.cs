using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelLoader 
{
    public Scene First;
    public static IEnumerator LoadLevel(string scenePath)
    {
        yield return SceneManager.LoadSceneAsync(scenePath, LoadSceneMode.Single);
    }
}
