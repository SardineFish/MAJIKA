using Inventory;
using UnityEngine;
using UnityEngine.UI;

namespace MAJIKA.GUI
{
    [ExecuteInEditMode]
    public class Slot : MonoBehaviour, IDragable, IDropable
    {
        public Sprite Background;
        public Sprite InnerShadow;
        public ItemWrapper Item;
        public ItemType AcceptType = ItemType.All;

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
            if (Item != null && Item.Item)
            {
                transform.Find("Item").GetComponent<Image>().sprite = Item.Item.Iconx32;
                transform.Find("Item").GetComponent<Image>().color = Item.Item.DecoratedColor;
            }
            else
            {
                transform.Find("Item").GetComponent<Image>().sprite = null;
                transform.Find("Item").GetComponent<Image>().color = new Color(1, 1, 1, 0);
            }
        }



        public bool Accept(DragData data)
        {
            return data != null && (data.Data as ItemWrapper) != null && ((data.Data as ItemWrapper).Item.Type | AcceptType) == AcceptType;
        }

        public DragData OnDrag()
        {
            if (Item == null || !Item.Item || Item.Amount <= 0)
            {
                return null;
            }

            return new DragData()
            {
                DragIamge = Item.Item.Iconx32,
                Data = Item
            };
        }

        public void OnDrop(DragData data)
        {
            var item = data.Data as ItemWrapper;
            if (item != null)
            {
                Item = item;
            }
        }
    }

}

