using Inventory;
using UnityEngine;
using UnityEngine.UI;

namespace MAJIKA.GUI
{
    [ExecuteInEditMode]
    public class Slot : MonoBehaviour, IDragable, IDropable, IFocusable
    {
        public ItemWrapper Item;
        public int Volume = 1;
        public Sprite Background;
        public Sprite InnerShadow;
        public ItemType AcceptType = ItemType.All;
        public bool Focused = false;

        // Use this for initialization
        void Start()
        {
            UpdateItem();
        }

        // Update is called once per frame
        void Update()
        {
            UpdateItem();
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
            UpdateItem();
            var items = data.Data as ItemWrapper;
            if (items == null)
                return false;
            else if (Item.Item == null && ((data.Data as ItemWrapper).Item.Type | AcceptType) == AcceptType)
                return true;
            else if (Item.Item == items.Item)
                return true;
            return false;
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
                Data = Item,
                DragTarget = this,
            };
        }

        public void OnDrop(DragData data)
        {
            var slot = data.DragTarget as Slot;
            if(slot)
            {
                var take = slot.Take(Volume);
                Put(take);
                slot.Put(take); // Put the rest back to source
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

        public Item Take()
        {
            var items = Take(1);
            return items.Amount > 0 ? items.Item : null;
        }

        public ItemWrapper Take(int count)
        {
            var items = new ItemWrapper()
            {
                Item = Item.Item,
                Amount = Mathf.Min(Item.Amount, count)
            };
            Item.Amount -= items.Amount;
            UpdateItem();
            return items;
        }

        public bool Put(Item item)
        {
            var wrapper = new ItemWrapper()
            {
                Item = item,
                Amount = 1
            };
            var success = Put(wrapper);
            return success && wrapper.Amount == 0;
        }

        public bool Put(ItemWrapper items)
        {
            if (Item == null)
            {
                Item = new ItemWrapper()
                {
                    Amount = 0,
                    Item = items.Item
                };
            }
            else if (Item.Item == null)
                Item.Item = items.Item;
            else if (Item.Item != items.Item)
                return false;
            var accept = Mathf.Min(Item.Amount + items.Amount, Volume) - Item.Amount;
            Item.Amount += accept;
            items.Amount -= accept;
            return true;
        }

        void UpdateItem()
        {
            if (Item == null)
                Item = new ItemWrapper()
                {
                    Amount = 0,
                    Item = null
                };
            if (Item != null && (Item.Amount == 0 || Item.Item == null))
            {
                Item.Item = null;
                Item.Amount = 0;
            }
        }
    }

}

