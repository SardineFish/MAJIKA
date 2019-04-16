using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

namespace MAJIKA.GUI
{
    public class Dropable : MonoBehaviour, IDropHandler
    {
        public void OnDrop(PointerEventData eventData)
        {
            var data = eventData.pointerDrag.GetInterface<IDragable>()?.OnDrag();
            var idropable = this.GetInterface<IDropable>();
            if (idropable !=null && idropable.Accept(data))
            {
                idropable.OnDrop(data);
            }
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