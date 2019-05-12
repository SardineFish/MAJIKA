using UnityEngine;
using System.Collections;

[RequireComponent(typeof(SkillController))]
public class Player : LifeEntity
{
    public Talker Talker;

    protected override void Start()
    {
        base.Start();

        var inventory = transform.Find(NameInventory).GetComponent<Inventory.Inventory>();
        inventory.Slots = new Inventory.ItemWrapper[inventory.Volume];
        for (var i = 0; i < inventory.Volume; i++)
        {
            if (i < Saves.Instance.Profile.Inventory.Length)
                inventory.Slots[i] = Saves.Instance.Profile.Inventory[i];
            else
                inventory.Slots[i] = new Inventory.ItemWrapper();
        }
        var equipment = inventory.GetComponent<Inventory.Equipment>();
        equipment.SkillSlots = new Inventory.ItemWrapper[4];
        for (var i = 0; i < equipment.SkillSlots.Length; i++)
        {
            if (i < Saves.Instance.Profile.SkillSlots.Length)
                equipment.SkillSlots[i] = Saves.Instance.Profile.SkillSlots[i];
            else
                equipment.SkillSlots[i] = new Inventory.ItemWrapper();
        }
    }

    public void SyncProfileToSaves()
    {
        var inventory = transform.Find(NameInventory).GetComponent<Inventory.Inventory>();
        var equipment = inventory.GetComponent<Inventory.Equipment>();
        Saves.Instance.Profile.Inventory = inventory.Slots;
        Saves.Instance.Profile.SkillSlots = equipment.SkillSlots;
    }
}
