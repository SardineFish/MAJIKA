using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEditor;
using Inventory;
using UnityEditor.SceneManagement;

namespace Assets.Editor
{
    [CustomEditor(typeof(Inventory.Inventory))]
    public class InventoryEditor:UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            var inventory = target as Inventory.Inventory;
            inventory.Slots = EditorUtilities.DrawArray("Slots", inventory.Slots, (slot) =>
            {
                EditorUtilities.Horizontal(() =>
                {
                    slot.Item = EditorGUILayout.ObjectField(slot.Item, typeof(Item), true) as Item; 
                    slot.Amount = EditorGUILayout.IntField(slot.Amount);
                });
                return slot;
            });
            Undo.RecordObject(target, "Modify Inventory");
            EditorGUILayout.Space();
        }
    }
}
