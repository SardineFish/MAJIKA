using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEditor;
namespace Assets.Editor
{
    class ImageAlign :UnityEditor.EditorWindow
    {
        [MenuItem("Window/My Window")]
        public static void ShowWindow()
        {
            EditorWindow.GetWindow(typeof(ImageAlign));
        }
        Texture2D texture;
        private void OnGUI()
        {
            texture = EditorGUILayout.ObjectField(texture, typeof(UnityEngine.Object), true) as Texture2D;
            
        }
    }
}
