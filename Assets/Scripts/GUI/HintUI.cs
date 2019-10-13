using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

namespace MAJIKA.GUI
{
    public class HintUI : MonoBehaviour, IPointerClickHandler
    {
        public void OnPointerClick(PointerEventData eventData)
        {
            gameObject.SetActive(false);
        }

        private void Start()
        {
            if (Saves.Instance.Profile.CompleteTutorial)
                gameObject.SetActive(false);
        }
    }

}