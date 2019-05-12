using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Inventory;

namespace MAJIKA.GUI
{
    public class SkillPanel : UIPanel<SkillPanel>
    {
        public SkillPanel():base()
        {
        }
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

        public override IEnumerator Show(float time = 0.1F)
        {
            var player = GameSystem.Instance.PlayerInControl;
            if (!player)
                return null;
            InventoryRenderer.Inventory = player.GetComponentInChildren<Inventory.Inventory>();
            var skillSlots = player.GetComponentInChildren<Equipment>()?.SkillSlots;
            if (skillSlots == null)
                return null;
            for (var i = 0; i < skillSlots.Length; i++)
            {
                Skills[i].GetComponent<UITemplate>().DataSource = skillSlots[i];
            }
            return base.Show(time);
        }
        public override IEnumerator Hide(float time = 0.2F)
        {
            Saves.Instance.Save();
            return base.Hide(time);
        }
    }

}
