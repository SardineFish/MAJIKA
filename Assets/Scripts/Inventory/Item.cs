﻿using UnityEngine;
using System.Collections;
using System.Linq;

namespace Inventory
{
    [CreateAssetMenu(fileName ="Item",menuName ="Inventory/Item")]
    public class Item : ScriptableObject
    {
        public string DisplayName;
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
    }

    public enum ItemType:int
    {
        Cloak = 1,
        Wand = 2,
        Stone = 4,
        All = Cloak | Wand | Stone,
    }
}