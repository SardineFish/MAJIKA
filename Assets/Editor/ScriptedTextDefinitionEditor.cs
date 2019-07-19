using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEditor;
using System.IO;
using MAJIKA.TextManager;

namespace Assets.Editor
{
    [CustomEditor(typeof(ScriptedTextDefinition))]
    class ScriptedTextDefinitionEditor : UnityEditor.Editor 
    {
        string searchFolder;
        public override void OnInspectorGUI()
        {
            var manager = target as ScriptedTextDefinition;

            EditorGUILayout.LabelField("Search in folder:");

            EditorUtilities.Horizontal(() =>
            {
                searchFolder = EditorGUILayout.TextField(searchFolder);
                if (GUILayout.Button("Browse"))
                    searchFolder = EditorUtility.OpenFolderPanel("Open", null, "");
            });
            EditorGUILayout.Space();
            if(GUILayout.Button("Reload"))
            {
                LoadFiles();
            }

            EditorGUILayout.Space();
            EditorGUILayout.PrefixLabel($"Definitions: {manager.DefinitionCount}");

            EditorUtilities.DrawList(manager.TextDefinitionCode)
                .Header("Text Definitions")
                .Item(code => EditorGUILayout.ObjectField(code, typeof(MAJIKA.Lua.LuaScript), true) as MAJIKA.Lua.LuaScript)
                .Render();

            Undo.RecordObject(target, "Edit Text Definition");
        }

        void LoadFiles()
        {
            var manager = target as ScriptedTextDefinition;
            var projectPath = new Uri(Application.dataPath);
            manager.TextDefinitionCode.Clear();
            manager.TextDefinitionCode = Directory.GetFiles(searchFolder, "*.lua", SearchOption.AllDirectories)
                .Select(file =>
                {
                    return AssetDatabase.LoadAssetAtPath<MAJIKA.Lua.LuaScript>(projectPath.MakeRelativeUri(new Uri(file)).ToString());
                })
                .ToList();
            manager.Reload();
        }
    }
}
