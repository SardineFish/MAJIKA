using System;
using System.Linq;
using UnityEngine;

namespace Inventory
{
    public class Inventory : EntityBehaviour
    {
        public int Volume = 12;
        public bool AutoPickup = false;
        public float PickupDistance = 1;
        [HideInInspector]
        public ItemWrapper[] Slots = new ItemWrapper[0];
        private void Update()
        {
            if (Slots.Length != Volume)
            {
                Array.Resize(ref Slots, Volume);
            }
            CleanUp();
        }
        public bool Add(Item item, int amount = 1)
        {
            var slot = Slots.Where(s => s.Item == item).FirstOrDefault();
            if (slot != null)
            {
                slot.Amount += 1;
                return true;
            }
            for (var i = 0; i < Slots.Length; i++)
            {
                if (Slots[i] == null)
                {
                    Slots[i] = new ItemWrapper()
                    {
                        Item = item,
                        Amount = amount
                    };
                    return true;
                }
            }
            return false;
        }
        public ItemWrapper Take(Item item, int amount = 1)
        {
            var slot = Slots.Where(s => s.Item == item).FirstOrDefault();
            if (slot == null)
            {
                return new ItemWrapper()
                {
                    Item = item,
                    Amount = 0
                };
            }

            slot.Amount -= Mathf.Min(slot.Amount, amount);
            return new ItemWrapper()
            {
                Item = item,
                Amount = Mathf.Min(slot.Amount, amount)
            };
        }
        public void CleanUp()
        {
            for (var i = 0; i < this.Slots.Length; i++)
            {
                if (Slots[i] == null)
                {
                    Slots[i] = new ItemWrapper()
                    {
                        Item = null,
                        Amount = 0,
                    };
                }

                if (Slots[i].Amount <= 0)
                {
                    Slots[i].Amount = 0;
                    Slots[i].Item = null;
                }
            }
        }
    }

}