using UnityEngine;
using System.Collections;

public class GameSystem : Singleton<GameSystem>
{
    public GameEntity PlayerInControl;
    private void Start()
    {
        GameObject.DontDestroyOnLoad(gameObject);
    }
}
