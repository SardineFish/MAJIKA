using UnityEngine;
using System.Collections;
using UnityEngine.Experimental.Input.Plugins.OnScreen;
using UnityEngine.EventSystems;
using UnityEngine.Experimental.Input;
using System.Collections.Generic;
using System.Linq;


public class VirtualButton : OnScreenActionControl, IPointerDownHandler, IPointerUpHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        SendValueToControl<float>(1);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        SendValueToControl<float>(0);
    }
}
