using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEditor;

namespace Assets.Editor
{
    [CustomEditor(typeof(RuntimeLayer))]
    [CanEditMultipleObjects]
    class RuntimeLayerEditor: UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            var layer = target as RuntimeLayer;
            //EditorUtility.SetDirty(layer);
            serializedObject.FindProperty("Layer").intValue = EditorGUILayout.LayerField("Layer", serializedObject.FindProperty("Layer").intValue);
            serializedObject.ApplyModifiedProperties();
        }
    }
}
