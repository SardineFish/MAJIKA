using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

namespace MAJIKA.GUI
{
    public class SelectMenu : UIPanel<SelectMenu>
    {
        public GameObject ItemPrefab;
        public Transform Container;
        List<MenuItem> Items = new List<MenuItem>();
        public static void ShowAsync(string[] items, Action<int> selectCallback)
        {
            Instance.gameObject.SetActive(true);
            Instance.StartCoroutine(Show(items, selectCallback));
        }
        public static IEnumerator Show(string[] items, Action<int> selectCallback)
        {
            yield return Instance.ShowItemsInternal(items, selectCallback);
        }
        IEnumerator ShowItemsInternal(string[] items, Action<int> selectCallback)
        {
            for (var i = 0; i < items.Length; i++)
            {
                int idx = i;
                var obj = Instantiate(ItemPrefab);
                obj.transform.SetParent(Container);
                var item = obj.GetComponent<MenuItem>();
                item.Init(items[i], (Action)(() => selectCallback(idx)));
                item.OnClick += Item_OnClick;
                Items.Add(item);
            }
            yield return Show();
            yield return null;
            while (Visible)
                yield return null;

        }

        private void Item_OnClick(MenuItem item)
        {
            StartCoroutine(HideInternal(item));
        }

        IEnumerator HideInternal(MenuItem selected)
        {
            yield return Hide(.2f);
            selected.GetData<Action>()?.Invoke();
            Items.ForEach(item => Destroy(item.gameObject));
            Items.Clear();
            gameObject.SetActive(false);
        }
    }
}
