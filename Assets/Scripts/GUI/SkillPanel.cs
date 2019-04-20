using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Inventory;

namespace MAJIKA.GUI
{
    public class SkillPanel : UIPanel<SkillPanel>
    {
        public Slot MajorMaterial;
        public List<Slot> MinorMateirals = new List<Slot>();
        public Slot ProductSlot;
        public InventoryRenderer InventoryRenderer;

        public Slot[] Skills;
     

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

        public override void Show(float time = .1f)
        {
            var player = GameSystem.Instance.PlayerInControl;
            if (!player)
                return;
            InventoryRenderer.Inventory = player.GetComponentInChildren<Inventory.Inventory>();
            var skillSlots = player.GetComponentInChildren<Equipment>()?.SkillSlots;
            if (skillSlots == null)
                return;
            for(var i=0;i<skillSlots.Length;i++)
            {
                Skills[i].GetComponent<UITemplate>().DataSource = skillSlots[i];
            }
            base.Show(time);
        }
    }

}
