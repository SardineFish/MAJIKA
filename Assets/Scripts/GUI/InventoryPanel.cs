using Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAJIKA.GUI
{
    public class InventoryPanel: UIPanel<InventoryPanel>
    {
        public Slot[] Skills;
        public InventoryRenderer InventoryRenderer;

        private void OnEnable()
        {
            InputManager.Instance.Controller.Actions.Inventory.performed += ctx =>
            {
                if (!this.gameObject.activeInHierarchy)
                    this.Show();
                else
                    this.Hide();
            };
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
            for (var i = 0; i < skillSlots.Length; i++)
            {
                Skills[i].GetComponent<UITemplate>().DataSource = skillSlots[i];
            }
            base.Show(time);
        }

        public override void Hide(float time = 0.2F)
        {
            base.Hide(time);
        }
    }
}
