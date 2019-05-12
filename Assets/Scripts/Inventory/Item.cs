using UnityEngine;
using System.Collections;
using System.Linq;

namespace Inventory
{
    [CreateAssetMenu(fileName ="Item",menuName ="Inventory/Item")]
    public class Item : ScriptableObject
    {
        public string DisplayName;
        [TextArea]
        public string Description;
        public ItemType Type;
        public Sprite Iconx32;
        public Sprite Iconx16;
        public Color DecoratedColor;
        public RuntimeAnimatorController DropedAnimation;
        public AudioClip PickupSoundEffect;
        [HideInInspector]
        public ItemProperty[] Properties = new ItemProperty[0];

        public T GetProperty<T>() where T: ItemProperty
        {
            return Properties.Where(prop => prop is T).FirstOrDefault() as T;
        }

        public ItemWrapper Create(int amount)
            => new ItemWrapper() { Item = this, Amount = amount };


        public static Recipe operator +(Item item1, Item item2)
        {
            return new Recipe()
            {
                Materials = new Item[] { item1, item2 }.ToList(),
                Product = null
            };
        }
        public static Recipe operator +(Item item, Recipe recipe)
        {
            recipe.Materials.Insert(0, item);
            return recipe;
        }
        public static Recipe operator +(Recipe recipe, Item item)
        {
            recipe.Materials.Add(item);
            return recipe;
        }
    }

    public enum ItemType:int
    {
        Cloak = 1,
        Wand = 2,
        Stone = 4,
        All = Cloak | Wand | Stone,
    }
}