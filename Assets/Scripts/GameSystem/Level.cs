using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Level : MonoBehaviour
{
    public List<MonoBehaviour> ActiveAtLoaded = new List<MonoBehaviour>();
    public void Ready()
    {
        ActiveAtLoaded.ForEach(cpn => cpn.enabled = true);
    }
}
