using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using MAJIKA.GUI;

namespace Inventory
{
    [ExecuteInEditMode]
    public class Slot : MonoBehaviour, IDragable, IDropable
    {
        public Sprite Background;
        public Sprite InnerShadow;
        public Item Item;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            GetComponent<Image>().sprite = Background;
            var mat = transform.Find("Item").GetComponent<Image>().material;
            mat.SetTexture("_InnerShadow", InnerShadow.texture);
            if (Item)
            {
                transform.Find("Item").GetComponent<Image>().sprite = Item.Iconx32;
                transform.Find("Item").GetComponent<Image>().color = Item.DecoratedColor;
            }
            else
            {
                transform.Find("Item").GetComponent<Image>().sprite = null;
                transform.Find("Item").GetComponent<Image>().color = new Color(1, 1, 1, 0);
            }
        }



        public bool Accept(DragData data)
        {
            return data.Data != null;
        }

        public DragData OnDrag()
        {
            if (!Item)
                return null;
            return new DragData()
            {
                DragIamge = Item.Iconx32,
                Data = Item
            };
        }

        public void OnDrop(DragData data)
        {
            var item = data.Data as Item;
            if (item)
                Item = item;
        }

    }

}