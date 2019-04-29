using UnityEngine;
using System.Collections;

public class CameraShake : CameraPlugin
{
    public float Strength = 1;
    public float Frequence = 1;

    public override CameraContext CameraUpdate(CameraContext modifier, float dt)
    {
        modifier.Position += new Vector2(Mathf.PerlinNoise(Time.time * Frequence, 0), Mathf.PerlinNoise(0, Time.time * Frequence)) * Strength;
        return modifier;
    }
}
