using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

[RequireComponent(typeof(GraphicRaycaster))]
public class VirtualInputManager : MonoBehaviour
{
    [SerializeField]
    List<VirtualButton> buttons = new List<VirtualButton>();
    GraphicRaycaster raycaster;
    PointerEventData data;
    EventSystem eventSystem;
    List<RaycastResult> results = new List<RaycastResult>(256);
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

    public void Remove(VirtualButton button)
    {
        buttons.Remove(button);
    }

    private void FixedUpdate()
    {
        if (Touchscreen.current == null)
            return;
        for (var i = 0; i < buttons.Count; i++)
        {
            buttons[i].ResetData();
        }
        for (var touchIdx = 0; touchIdx < Touchscreen.current.touches.Count; touchIdx++)
        {
            var touch = Touchscreen.current.touches[touchIdx];
            switch (touch.phase.ReadValue())
            {
                case UnityEngine.InputSystem.TouchPhase.Began:
                case UnityEngine.InputSystem.TouchPhase.Moved:
                    goto AvailableTouch;
            }
            // Ingore this touch
            continue;

            AvailableTouch:

            //var touch = Touchscreen.current.activeTouches[touchIdx];
            //Debug.Log($"{touch.touchId.ReadValue()} {touch.phase.ReadValue()} {touch.pressure.ReadValue()} {touch.radius.ReadValue()}");
            //var pos = Touchscreen.current.activeTouches[touchIdx].position;
            //Debug.Log(pos.ReadValue());
            data.position = touch.position.ReadValue();//Input.GetTouch(touchIdx).position;
            
            raycaster.Raycast(data, results);
            //results.ForEach(result => Debug.Log(result.gameObject));
            if (results.Count <= 0)
                continue;
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
