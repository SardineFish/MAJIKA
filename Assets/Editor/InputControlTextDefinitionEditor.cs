using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAJIKA.TextManager;
using UnityEngine;
using UnityEditor;

namespace Assets.Editor
{
    [CustomEditor(typeof(InputControlTextDefinition))]
    class InputControlTextDefinitionEditor: UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            var textDef = target as InputControlTextDefinition;
            EditorUtilities.DrawList(textDef.InputActions)
                .Header("Available Input Actions:")
                .Item((action) => EditorGUILayout.LabelField(action))
                .ReadOnly()
                .Render();
            /*
            var textDef = target as InputControlTextDefinition;
            EditorUtilities.DrawList(textDef.GamePadActionText.Keys)
                .Header("GamePad")
                .Item(key =>
                {
                    textDef.GamePadActionText[key] = EditorGUILayout.TextField(key, textDef.GamePadActionText[key]);
                    return key;
                })
                .OnAdd(false)
                .OnRemove(false)
                .Render();

            EditorUtilities.DrawList(textDef.KeyboardActionText.Keys)
                .Header("Keyboard")
                .Item(key =>
                {
                    textDef.KeyboardActionText[key] = EditorGUILayout.TextField(key, textDef.KeyboardActionText[key]);
                    return key;
                })
                .OnAdd(false)
                .OnRemove(false)
                .Render();

            if (GUILayout.Button("Reload"))
                textDef.Reload();*/

            base.OnInspectorGUI();

            Undo.RecordObject(target, "Edit Text Definitions");
        }
    }
}
