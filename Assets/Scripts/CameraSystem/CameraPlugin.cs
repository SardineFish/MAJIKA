using UnityEngine;
using System.Collections;

public abstract class CameraPlugin : MonoBehaviour
{
    public bool Enabled = true;
    public MainCamera Camera => GetComponent<MainCamera>();
    public virtual void CameraUpdate(float dt) { }
}
