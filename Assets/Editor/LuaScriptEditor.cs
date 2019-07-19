using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAJIKA.Lua;
using UnityEngine;
using UnityEditor;

namespace Assets.Editor
{
    [CustomEditor(typeof(LuaScript))]
    class LuaScriptEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            var script = target as LuaScript;
            EditorGUILayout.LabelField("Code:");
            EditorGUILayout.TextArea(script.text);
        }
    }
}
