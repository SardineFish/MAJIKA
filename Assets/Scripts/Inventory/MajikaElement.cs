using UnityEngine;
using System.Collections;

namespace Inventory
{
    [CreateAssetMenu(fileName ="Element",menuName ="Inventory/MajikaElement")]
    public class MajikaElement : ItemProperty
    {
        public GameObject Skill;
    }
}