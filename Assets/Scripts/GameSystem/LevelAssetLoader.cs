using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class LevelAssetLoader : MonoBehaviour
{
    List<UnityEngine.Object> resources = new List<UnityEngine.Object>();

    [ReadOnly]
    public int AssetCount => resources.Count;

    private void Awake()
    {
        MAJIKA.GUI.LoadingUI.Instance.ShowAsync();
    }

    private void Start()
    {
        var playableDirectors = Resources.FindObjectsOfTypeAll<UnityEngine.Playables.PlayableDirector>()
            .Where(playable => playable.gameObject)
            .ToList();
        //playableDirectors.ForEach(director => director.RebuildGraph());
        playableDirectors.ForEach(director => director.Evaluate());
        Debug.Log($"Load {playableDirectors.Count} playables.");
    }

    public void LoadAllInFolder(string path)
    {
        var loaded = Resources.LoadAll(path);
        Debug.Log($"Loaded {loaded.Length} resources.");
        resources.AddRange(loaded);
    }

    public void UnloadAll()
    {
        resources.ForEach(res => Resources.UnloadAsset(res));
    }
}
