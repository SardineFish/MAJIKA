using UnityEngine;
using System.Collections;

public class SingletonAsset<T> : ScriptableObject where T : SingletonAsset<T>
{
    public static T Asset;
    public SingletonAsset()
    {
        Asset = this as T;
    }
}
