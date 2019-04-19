using UnityEngine;
using System.Collections;
using UnityEngine.Experimental.Input.Plugins.OnScreen;
using UnityEngine.EventSystems;
using UnityEngine.Experimental.Input;
using System.Collections.Generic;
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

public class VirtualButton : OnScreenControl, IPointerDownHandler, IPointerUpHandler
{
    public ActionBind ActionBind;
    Dictionary<ActionBind, InputAction> dict = new Dictionary<ActionBind, InputAction>();
    private void OnEnable()
    {
        dict[ActionBind.Jump] = InputManager.Instance.GamePlay.Jump;
        dict[ActionBind.Climb] = InputManager.Instance.GamePlay.Climb;
        dict[ActionBind.Skill1] = InputManager.Instance.GamePlay.Skill1;
        dict[ActionBind.Skill2] = InputManager.Instance.GamePlay.Skill2;
        dict[ActionBind.Skill3] = InputManager.Instance.GamePlay.Skill3;
        dict[ActionBind.Skill4] = InputManager.Instance.GamePlay.Skill4;
        dict[ActionBind.Interact] = InputManager.Instance.Actions.Interact;
        dict[ActionBind.Inventory] = InputManager.Instance.Actions.Inventory;
        SetBind(dict[ActionBind]);
    }
    void SetBind(InputAction action)
    {
        var control = action.controls
            .Where(ctrl => ctrl.valueType == typeof(float))
            .FirstOrDefault();
        if (control == null)
            return;
        this.controlPath = $"/<{control.parent.layout}>/{control.name}";
    }
    private void Update()
    {
        //SetBind(dict[ActionBind]);
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        SendValueToControl<float>(1);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        SendValueToControl<float>(0);
    }
}
