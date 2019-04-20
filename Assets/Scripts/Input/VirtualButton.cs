using UnityEngine;
using System.Collections;
using UnityEngine.Experimental.Input.Plugins.OnScreen;
using UnityEngine.EventSystems;
using UnityEngine.Experimental.Input;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.UI;

public class VirtualButton : OnScreenActionControl
{
    protected override void OnEnable()
    {
        base.OnEnable();
        GetComponentInParent<VirtualInputManager>()?.Register(this);
    }

    public void TouchCallback()
    {
        SendValueToControl<float>(1);
    }

    public void Reset()
    {
        SendValueToControl<float>(0);
    }
}
