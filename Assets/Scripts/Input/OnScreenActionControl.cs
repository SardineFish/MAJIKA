using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.OnScreen;
using System.Linq;

public enum ActionBind
{
    Jump,
    Climb,
    Skill1,
    Skill2,
    Skill3,
    Skill4,
    Interact,
    Inventory,
}
public class OnScreenActionControl : OnScreenControl
{

    [SerializeField]
    [InputControl(layout = "Vector2")]
    private string _controlPath;
    protected override string controlPathInternal
    {
        get => _controlPath;
        set => _controlPath = value;
    }

    protected virtual void OnEnable()
    {
        this.controlPath = _controlPath;
    }
}
