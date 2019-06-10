using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;

namespace Assets.Editor
{
    [CustomEditor(typeof(Testing.Test))]
    [CanEditMultipleObjects]
    class TestEditor:UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            var test = target as Testing.Test;
            test.FloatValue = EditorGUILayout.FloatField("Float Value", test.FloatValue);
            Undo.RecordObject(target, "Modify Test");
            base.OnInspectorGUI();
        }
    }
}
