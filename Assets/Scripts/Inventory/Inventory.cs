using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Inventory
{
    public class Inventory : EntityBehaviour<GameEntity>
    {
        public bool AutoPickup = false;
        public float PickupDistance = 1;
        public List<Item> Items = new List<Item>();
        private void Update()
        {
            
        }
    }

}