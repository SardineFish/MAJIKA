using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Inventory;

namespace MAJIKA.GUI
{
    public class CraftUI : Singleton<CraftUI>
    {
        public Slot MajorMaterial;
        public List<Slot> MinorMateirals = new List<Slot>();
        public Slot ProductSlot;

        public void Craft()
        {
            var major = MajorMaterial.Take();
            if (!major)
                return;
            var minors = MinorMateirals
                .Select(slot => slot.Take())
                .Where(item => item)
                .ToArray();
    
            var materials = new List<Item>();
            materials.Add(major);
            materials.AddRange(minors);

            var product = CraftSystem.Instance.Craft(materials.ToArray());
            if (product)
                ProductSlot.Put(product);
        }
    }

}
