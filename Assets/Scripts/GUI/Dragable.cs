using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

namespace MAJIKA.GUI
{
    public class Dragable : MonoBehaviour, IDragHandler, IEndDragHandler
    {
        public Sprite DragImage;

        public void OnDrag(PointerEventData eventData)
        {
            var data = this.GetInterface<IDragable>()?.OnDrag();
            if (data != null)
            {
                Debug.Log($"{gameObject.name} Drag");
                eventData.Use();
                DragNDropSystem.Instance.UpdateDragging(data);
            }
            else
                eventData.Reset();
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            DragNDropSystem.Instance.DestroyDragging();
        }

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}