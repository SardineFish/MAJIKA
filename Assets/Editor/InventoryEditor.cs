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
            bool edited = false;
            inventory.Slots = EditorUtilities.DrawArray("Slots", inventory.Slots, (slot) =>
            {
                EditorUtilities.Horizontal(() =>
                {
                    Item item = EditorGUILayout.ObjectField(slot.Item, typeof(Item), true) as Item;
                    if (slot.Item != item)
                        edited = true;
                    slot.Item = item;
                    var amount = EditorGUILayout.IntField(slot.Amount);
                    if (amount != slot.Amount)
                        edited = true;
                    slot.Amount = amount;
                });
                return slot;
            });
            if (edited)
                EditorSceneManager.MarkSceneDirty(inventory.gameObject.scene);
            EditorGUILayout.Space();
        }
    }
}
