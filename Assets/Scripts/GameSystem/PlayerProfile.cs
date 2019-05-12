using UnityEngine;
using System.Collections;
using System;
using Inventory;

[Serializable]
public class PlayerProfile
{
    [NonSerialized]
    public ItemWrapper[] Inventory;
    [NonSerialized]
    public ItemWrapper[] SkillSlots;
    public SerializableItem[] inventory;
    public SerializableItem[] skillSlots;
}

[Serializable]
public class SerializableItem
{
    public string name;
    public int amount;
}
