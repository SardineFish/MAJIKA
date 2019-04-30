using UnityEngine;
using System.Collections;

public abstract class CameraPlugin : MonoBehaviour
{
    public bool Enabled = true;
    public SceneCamera Camera => GetComponent<SceneCamera>();
    public virtual CameraContext CameraUpdate(CameraContext modifier, float dt) { return modifier; }
}
