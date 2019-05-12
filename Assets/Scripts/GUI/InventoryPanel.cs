using Inventory;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace MAJIKA.GUI
{
    public class InventoryPanel: UIPanel<InventoryPanel>
    {
        public Slot[] Skills;
        public InventoryRenderer InventoryRenderer;

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
