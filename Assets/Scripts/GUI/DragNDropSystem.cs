using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace MAJIKA.GUI
{
    public class DragNDropSystem : Singleton<DragNDropSystem>
    {
        public GameObject DragIconPrefab;
        public GameObject DraggingIcon;
        public void UpdateDragging(DragData data)
        {
            if(!DraggingIcon)
            {
                DraggingIcon = Utility.Instantiate(DragIconPrefab, gameObject);
            }
            Vector2 pos;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(transform as RectTransform, Input.mousePosition, GetComponent<Canvas>().worldCamera, out pos);
            DraggingIcon.transform.position = GetComponent<Canvas>().transform.TransformPoint(pos);
            DraggingIcon.GetComponent<Image>().sprite = data.DragIamge;
        }
        public void DestroyDragging()
        {
            Destroy(DraggingIcon);
            DraggingIcon = null;
        }
    }

}