using Inventory;
using UnityEngine;
using UnityEngine.UI;

namespace MAJIKA.GUI
{
    [ExecuteInEditMode]
    public class Slot : MonoBehaviour, IDragable, IDropable, IFocusable
    {
        public Sprite Background;
        public Sprite InnerShadow;
        public ItemWrapper Item;
        public ItemType AcceptType = ItemType.All;
        public bool Focused = false;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            var transparent = new Color(0, 0, 0, 0);
            //GetComponent<CanvasRenderer>()
            GetComponent<Image>().sprite = Background;
            var mat = transform.Find("Item").GetComponent<Image>().material;
            mat.SetTexture("_InnerShadow", InnerShadow.texture);
            if (Item != null && Item.Item)
            {
                transform.Find("Item").GetComponent<Image>().sprite = Item.Item.Iconx32;
                transform.Find("Item").GetComponent<Image>().color = Color.white;
                transform.Find("BG").GetComponent<Image>().sprite = InnerShadow;
                transform.Find("BG").GetComponent<Image>().color = Item.Item.DecoratedColor;
            }
            else
            {
                transform.Find("Item").GetComponent<Image>().sprite = null;
                transform.Find("Item").GetComponent<Image>().color = transparent;
                transform.Find("BG").GetComponent<Image>().sprite = null;
                transform.Find("BG").GetComponent<Image>().color = Focused ? new Color(1, 1, 1, 0.35f) : transparent;
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

        public bool Focus()
        {
            throw new System.NotImplementedException();
        }

        public bool Unfocus()
        {
            throw new System.NotImplementedException();
        }
    }

}

