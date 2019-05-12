using UnityEngine;
using System.Collections;
using Inventory;
using System.Linq;

public class AssetsManager : Singleton<AssetsManager>
{
    private Skill[] Skills;
    private Item[] Items;
    protected void Awake()
    {
        Items = Resources.LoadAll<Item>("Items");
    }

    public Item GetItem(string name)
    {
        for (var i = 0; i < Items.Length; i++)
        {
            if (Items[i].name == name)
                return Items[i];
        }
        return null;
    }

    public Skill GetSkill(string name)
    {
        for (var i = 0; i < Skills.Length; i++)
        {
            if (Skills[i].name == name)
                return Skills[i];
        }
        return null;
    }

    public static Item FindItem(string name) => Instance?.GetItem(name);

    // public static Skill FindSkill(string name) => Instance?.GetSkill(name);
}