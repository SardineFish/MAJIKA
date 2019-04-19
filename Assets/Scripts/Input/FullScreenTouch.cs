using UnityEngine;
using System.Collections;
using MAJIKA.GUI;
using UnityEngine.EventSystems;

public class FullScreenTouch: Singleton<FullScreenTouch>, IPointerClickHandler
{
    bool touched = false;
    public IEnumerator WaitForTouch()
    {
        while(!touched)
        {
            yield return null;
        }
        touched = false;
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        touched = true;
    }
}
