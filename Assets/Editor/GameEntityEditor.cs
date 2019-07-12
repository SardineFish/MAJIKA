using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEditor;

namespace Assets.Editor
{
    [CustomEditor(typeof(GameEntity), true)]
    [CanEditMultipleObjects]
    class GameEntityEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            var entity = target as GameEntity;
            if (Application.isPlaying)
                entity.active = EditorGUILayout.Toggle("Active", entity.active);
            else
                EditorGUILayout.Toggle("Active", entity.active);
            EditorGUILayout.Space();
            base.OnInspectorGUI();
        }
    }
}
