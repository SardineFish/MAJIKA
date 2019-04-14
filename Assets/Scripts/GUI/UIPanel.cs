using UnityEngine;
using System.Collections;

namespace MAJIKA.GUI
{
    public abstract class UIPanel<T> : Singleton<T> where T : UIPanel<T>
    {

        public virtual void Hide()
        {
            if (gameObject.activeInHierarchy)
                StartCoroutine(Utility.HideUI(GetComponent<CanvasGroup>(), .3f));
        }

        public virtual void Show()
        {
            if (!gameObject.activeInHierarchy)
            {
                gameObject.SetActive(true);
                GetComponent<CanvasGroup>().alpha = 0;
                StartCoroutine(Utility.ShowUI(GetComponent<CanvasGroup>(), .3f));
                GetComponent<PageContainer>()?.Reset();
            }
        }
    }
}