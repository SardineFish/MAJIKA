using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEditor;
using Inventory;

namespace Assets.Editor
{
    [CustomEditor(typeof(Item))]
    [CanEditMultipleObjects]
    class ItemEditor:UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            var item = target as Item;
            EditorUtilities.DrawArray("Properties", item.Properties, (prop) => EditorGUILayout.ObjectField(prop, typeof(ItemProperty), false) as ItemProperty);
            EditorUtility.SetDirty(target);
        }
    }
}
