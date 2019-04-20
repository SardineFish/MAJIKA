using UnityEngine;
using System.Collections;

public class TimingTest : MonoBehaviour
{
    public int TargetFrameRate = 60;
    public float TimeScale = 1;
    // Use this for initialization
    void Start()
    {
        QualitySettings.vSyncCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Application.targetFrameRate = TargetFrameRate;
        Time.timeScale = TimeScale;
    }
}
