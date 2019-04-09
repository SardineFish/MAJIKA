using UnityEngine;
using System.Linq;
using System.Collections;

public class PageContainer : MonoBehaviour
{
    private void Start()
    {
        GetComponentsInChildren<UIPage>()
            .ForEach(p => p.gameObject.SetActive(false));

        GetComponentsInChildren<UIPage>()
            .Where(p => p.IsDefault)
            .FirstOrDefault()
            ?.gameObject.SetActive(true);
    }

    public void Show(UIPage page)
    {
        GetComponentsInChildren<UIPage>().ForEach(p => p.gameObject.SetActive(false));
        page.gameObject.SetActive(true);
    }

    public void PageNext()
    {   
    }

    public void PageBack()
    {

    }
}