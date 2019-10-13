using UnityEngine;
using System.Collections;
using System;
using Inventory;
using MoonSharp.Interpreter;

[Serializable]
[MoonSharpUserData]
public class PlayerProfile
{
    [NonSerialized]
    [MoonSharpHidden]
    public ItemWrapper[] Inventory;
    [NonSerialized]
    [MoonSharpHidden]
    public ItemWrapper[] SkillSlots;
    public SerializableItem[] inventory;
    public SerializableItem[] skillSlots;
    public bool CompleteTutorial = false;
}

[Serializable]
[MoonSharpUserData]
public class SerializableItem
{
    public string name;
    public int amount;
}
