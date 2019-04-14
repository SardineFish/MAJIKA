using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEditor;
using Inventory;
using System.Reflection;

namespace Assets.Editor
{
    [CustomEditor(typeof(ISlotEditor), true)]
    class SlotEditor: UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            var type = target.GetType();
            type.GetFields()
                .Where(field =>
                    field.GetCustomAttributes(typeof(SlotAttribute), true)
                    .FirstOrDefault() != null)
                .ForEach(field =>
                {
                    var attr = field.GetCustomAttributes(typeof(SlotAttribute), true).FirstOrDefault() as SlotAttribute;
                    var name = attr.Name;
                    

                });
        }
        
    }
}
