using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem.OnScreen;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
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

    private void OnDestroy()
    {
        GetComponentInParent<VirtualInputManager>()?.Remove(this);
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
