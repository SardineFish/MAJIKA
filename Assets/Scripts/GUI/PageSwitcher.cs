using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public enum PageSwitch
{
    Target,
    Next,
    Back,
}

public class PageSwitcher : MonoBehaviour,IPointerClickHandler
{
    public PageSwitch Switch = PageSwitch.Target;
    public UIPage SwitchTo;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnPointerClick(PointerEventData eventData)
    {
        switch (Switch)
        {
            case PageSwitch.Target:
                GetComponentInParent<PageContainer>()?.Show(SwitchTo);
                break;
            case PageSwitch.Next:
                GetComponentInParent<PageContainer>()?.PageNext();
                break;
            case PageSwitch.Back:
                GetComponentInParent<PageContainer>()?.PageBack();
                break;
        }
    }
}