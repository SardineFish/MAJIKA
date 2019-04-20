using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.Experimental.Input;

[RequireComponent(typeof(GraphicRaycaster))]
public class VirtualInputManager : MonoBehaviour
{
    [SerializeField]
    List<VirtualButton> buttons = new List<VirtualButton>();
    GraphicRaycaster raycaster;
    PointerEventData data;
    EventSystem eventSystem;
    List<RaycastResult> results = new List<RaycastResult>();
    private void OnEnable()
    {
        raycaster = GetComponentInParent<GraphicRaycaster>();
        eventSystem = GameObject.FindObjectOfType<EventSystem>();
        data = new PointerEventData(eventSystem);
    }

    public void Register(VirtualButton button)
    {
        buttons.Add(button);
    }

    private void FixedUpdate()
    {
        if (Touchscreen.current == null)
            return;
        for (var i = 0; i < buttons.Count; i++)
        {
            buttons[i].Reset();
        }
        if (Touchscreen.current.activeTouches.Count > 0)
            Debug.Log(Touchscreen.current.activeTouches.Count);
        for (var touchIdx = 0; touchIdx < Touchscreen.current.activeTouches.Count; touchIdx++)
        {
            var touch = Touchscreen.current.activeTouches[touchIdx];
            Debug.Log($"{touch.touchId.ReadValue()} {touch.phase.ReadValue()} {touch.pressure.ReadValue()} {touch.radius.ReadValue()}");
            var pos = Touchscreen.current.activeTouches[touchIdx].position;
            //Debug.Log(pos.ReadValue());
            data.position = pos.ReadValue();
            raycaster.Raycast(data, results);
            //results.ForEach(result => Debug.Log(result.gameObject));
            if (results.Count <= 0)
                return;
            for (var i = 0; i < buttons.Count; i++)
            {
                if (buttons[i].gameObject == results[0].gameObject)
                {
                    buttons[i].TouchCallback();
                    break;
                }
            }
            results.Clear();
        }
    }
}
