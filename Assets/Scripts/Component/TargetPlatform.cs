using UnityEngine;
using System.Collections;


public class TargetPlatform : MonoBehaviour
{
    public GenericPlatform Platform;

    private void Awake()
    {
        if (Utility.GetGenericPlatform(Application.platform) == Platform)
            gameObject.SetActive(true);
        else
            gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Utility.GetGenericPlatform(Application.platform) != Platform)
            gameObject.SetActive(false);
    }
}
