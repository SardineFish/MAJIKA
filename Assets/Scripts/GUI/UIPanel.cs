using System.Collections;
using UnityEngine;

namespace MAJIKA.GUI
{
    [RequireComponent(typeof(CanvasGroup))]
    public abstract class UIPanel<T> : Singleton<T> where T : UIPanel<T>
    {
        public bool Visible = false;
        System.Guid lockID;
        Coroutine coroutineShow;
        Coroutine coroutineHide;
        protected virtual void Update()
        {
            if (InputManager.Instance.Controller.Actions.Back.WasPressedThisFrame())
                HideAsync();
        }

        public virtual IEnumerator Show(float time = .1f)
        {
            if (Visible)
                yield break;
            if (coroutineHide != null)
                StopCoroutine(coroutineHide);
            coroutineHide = null;
            Visible = true;

            var player = GameSystem.Instance.PlayerInControl;
            if (player)
            {
                lockID = player.GetComponent<EntityController>().Lock();
            }
            GetComponent<CanvasGroup>().alpha = 0;
            GetComponent<PageContainer>()?.Reset();
            yield return Utility.ShowUI(GetComponent<CanvasGroup>(), time);
        }


        public virtual IEnumerator Hide(float time = .2f)
        {
            if (!Visible)
                yield break;
            if (coroutineShow != null)
                StopCoroutine(coroutineShow);
            coroutineShow = null;
            Visible = false;

            var player = GameSystem.Instance.PlayerInControl;
            if (!player)
                player = null;
            player?.GetComponent<EntityController>().UnLock(lockID);
            if (gameObject.activeInHierarchy)
            {
                yield return Utility.HideUI(GetComponent<CanvasGroup>(), time);
            }
        }
        public void HideAsync(float time = .2f)
        {
            if (!gameObject.activeInHierarchy)
                return;
            StartCoroutine(Hide(time));
        }

        public void ShowAsync(float time = .1f)
        {
            if (!gameObject.activeInHierarchy)
            {
                gameObject.SetActive(true);
            }
            StartCoroutine(Show(time));
        }
    }
}