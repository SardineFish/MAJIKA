using UnityEngine;
using System.Collections;
using System.Linq;

public class PlatformSpecificUI : MonoBehaviour
{
    public RuntimePlatform TargetPlatform;

    private void OnEnable()
    {
        if(transform.parent)
        {
            var platformUI =  transform.parent.GetComponentsInChildren<PlatformSpecificUI>(true);
            platformUI.Where(ui => ui.TargetPlatform != Application.platform)
                .ForEach(ui => ui.gameObject.SetActive(false));
            platformUI.Where(ui => ui.TargetPlatform == Application.platform)
                .ForEach(ui => ui.gameObject.SetActive(true));
        }
    }
}
