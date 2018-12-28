using UnityEngine;
using System.Collections;
using System.Linq;

namespace Inventory
{
    [CreateAssetMenu(fileName ="Item",menuName ="Inventory/Item")]
    public class Item : ScriptableObject
    {
        public string DisplayName;
        public Sprite Icon;
        public RuntimeAnimatorController DropedAnimation;
        public AudioClip PickupSoundEffect;
        [HideInInspector]
        public ItemProperty[] Properties;

        public T GetProperty<T>() where T: ItemProperty
        {
            return Properties.Where(prop => prop is T).FirstOrDefault() as T;
        }
    }

}