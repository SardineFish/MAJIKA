using UnityEngine;
using System.Collections;

namespace MAJIKA.GUI
{
    [RequireComponent(typeof(CanvasGroup))]
    public abstract class UIPanel<T> : Singleton<T> where T : UIPanel<T>
    {
        System.Guid lockID;
        protected virtual void Update()
        {
            if (NewInputManager.Instance.Controller.Actions.Back.WasPressedThisFrame())
                Hide();
        }

        public IEnumerator WaitHide(float time = .2f)
        {
            var player = GameSystem.Instance.PlayerInControl;
            player?.GetComponent<EntityController>().UnLock(lockID);
            if (gameObject.activeInHierarchy)
            {
                yield return Utility.HideUI(GetComponent<CanvasGroup>(), time);
            }
        }

        public virtual void Hide(float time = .2f)
        {
            if (gameObject.activeInHierarchy)
            {
                StartCoroutine(WaitHide(time));
            }
        }

        public IEnumerator WaitShow(float time = .1f)
        {
            if (!gameObject.activeInHierarchy)
            {
                gameObject.SetActive(true);
            }
            var player = GameSystem.Instance.PlayerInControl;
            if (player)
            {
                lockID = player.GetComponent<EntityController>().Lock();
            }
            GetComponent<CanvasGroup>().alpha = 0;
            GetComponent<PageContainer>()?.Reset();
            yield return Utility.ShowUI(GetComponent<CanvasGroup>(), time);
        }

        public virtual void Show(float time = .1f)
        {
            if (!gameObject.activeInHierarchy)
            {
                gameObject.SetActive(true);
                StartCoroutine(WaitShow(.1f));
            }
        }
    }
}