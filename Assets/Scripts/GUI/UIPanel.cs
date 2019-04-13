using UnityEngine;
using System.Collections;

namespace MAJIKA.GUI
{
    public abstract class UIPanel<T> : Singleton<T> where T : UIPanel<T>
    {

        public virtual void Hide()
        {
            StartCoroutine(Utility.HideUI(GetComponent<CanvasGroup>(), 1));
        }

        public virtual void Show()
        {
            StartCoroutine(Utility.ShowUI(GetComponent<CanvasGroup>(), 1));
        }
    }
}