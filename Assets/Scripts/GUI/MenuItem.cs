using UnityEngine;
using System.Collections;
using System;
using TMPro;
using System.Collections.Generic;
using UnityEngine.EventSystems;

namespace MAJIKA.GUI
{
    public class MenuItem : MonoBehaviour, IFocusable, UnityEngine.EventSystems.IPointerClickHandler
    {
        public TextMeshProUGUI Text;
        public event Action<MenuItem> OnClick;
        public event Action<MenuItem> OnFocus;
        public event Action<MenuItem> OnUnfocus;
        private object data;

        public void Init(string text)
        {
            Text.text = text;
        }

        public void Init<T>(string text, T data)
        {
            Text.text = text;
            this.data = data;
        }
        public T GetData<T>()
        {
            return (T)this.data;
        }

        public void Click()
        {
            OnClick?.Invoke(this);
        }

        public void Focus()
        {
            OnClick?.Invoke(this);
        }

        bool IFocusable.Focus()
        {
            OnFocus?.Invoke(this);

            return true;
        }

        public bool Unfocus()
        {
            OnUnfocus?.Invoke(this);
            return true;
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            this.Click();
        }
    }

}