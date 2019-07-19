using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEditor;
using System.IO;

namespace Assets.Editor
{
    [CustomEditor(typeof(TextManager))]
    class TextManagerEditor : UnityEditor.Editor 
    {
        string searchFolder;
        public override void OnInspectorGUI()
        {
            var manager = target as TextManager;

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
                .Item(code => EditorGUILayout.ObjectField(code, typeof(TextAsset), true) as TextAsset)
                .Render();

            Undo.RecordObject(target, "Edit I18nManager");
        }

        void LoadFiles()
        {
            var manager = target as TextManager;
            var projectPath = new Uri(Application.dataPath);
            manager.TextDefinitionCode.Clear();
            manager.TextDefinitionCode = Directory.GetFiles(searchFolder, "*.lua", SearchOption.AllDirectories)
                .Select(file =>
                {
                    return AssetDatabase.LoadAssetAtPath<TextAsset>(projectPath.MakeRelativeUri(new Uri(file)).ToString());
                })
                .ToList();
            manager.Reload();
        }
    }
}
