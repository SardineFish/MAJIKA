using UnityEngine;
using System.Collections;

public class GameSystem : Singleton<GameSystem>
{
    public string TutorialScenePath;
    public GameEntity PlayerInControl;
    private void Start()
    {
        GameObject.DontDestroyOnLoad(gameObject);
    }
}
