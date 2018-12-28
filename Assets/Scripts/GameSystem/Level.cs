using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Level : Singleton<Level>
{
    public const string EventFailed = "Failed";
    public const string EventPass = "Pass";
    public List<MonoBehaviour> ActiveAtLoaded = new List<MonoBehaviour>();
    public void Ready()
    {
        ActiveAtLoaded.ForEach(cpn => cpn.enabled = true);
    }
}
