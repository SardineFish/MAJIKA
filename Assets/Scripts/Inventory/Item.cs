using UnityEngine;
using System.Collections;

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
    }

}