using UnityEngine;
using UnityEditor;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Assets.Editor
{
    public class CharSetGenerator : EditorWindow
    {
        string folder;
        string searchPattern = "*.*";
        string outputFile = "";
        HashSet<char> charset = new HashSet<char>();
        [MenuItem("Tools/SardineFish/CharSet Generator")]
        static void ShowWindow()
        {
            var window = EditorWindow.GetWindow<CharSetGenerator>();
            window.Show();
        }

        private void OnGUI()
        {
            GUIStyle style = new GUIStyle();
            style.fontStyle = FontStyle.Bold;
            EditorGUILayout.LabelField("CharSet Generator", style);
            EditorUtilities.Horizontal(() =>
            {
                folder = EditorGUILayout.TextField("Folder", folder);
                if (GUILayout.Button("Browse"))
                {
                    folder = EditorUtility.OpenFolderPanel("Folder", folder, "");
                    Debug.Log(folder);
                }
            });
            searchPattern = EditorGUILayout.TextField("Search Pattern", searchPattern);
            EditorGUILayout.Space();
            EditorUtilities.Horizontal(() =>
            {
                outputFile = EditorGUILayout.TextField("Save to File", outputFile);
                if (GUILayout.Button("Browse"))
                    outputFile = EditorUtility.SaveFilePanel("Save", null, "CharSet", "txt");
            });
            
            if(GUILayout.Button("Generate"))
            {
                Generate();
                SaveToFile();
            }

            EditorGUILayout.LabelField($"Characters: {charset.Count}");
        }

        void SaveToFile()
        {
            if (outputFile == "")
                return;
            var text = charset.Select(chr => chr.ToString())
                .Aggregate((a, b) => a + b);
            File.WriteAllText(outputFile, text);
        }

        void Generate()
        {
            charset.Clear();
            if (folder == "")
                return;
            
            var files = Directory.GetFiles(folder, searchPattern, SearchOption.AllDirectories);
            files.ForEach(LoadFromFile);
        }

        void LoadFromFile(string path)
        {
            var text = File.ReadAllText(path);
            text.ForEach(chr => charset.Add(chr));
        }
    }
}
