using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEditor;

namespace Assets.Editor
{
    [CanEditMultipleObjects]
    [CustomEditor(typeof(PhysicsRootMotion))]
    class PhysicsRootMotionEditor : UnityEditor.Editor
    {
        Vector3 origin;
        bool enableEdit = false;
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            var rootMotion = target as PhysicsRootMotion;

            if (GUILayout.Button("Set Origin"))
            {
                origin = rootMotion.transform.position;
            }

            if (GUILayout.Button("Reset"))
            {
                rootMotion.transform.position = origin;
                rootMotion.Position = Vector3.zero;
                EditorUtility.SetDirty(rootMotion);
            }
            enableEdit = GUILayout.Toggle(enableEdit, "Edit Offset", "Button");
        }

        private void OnSceneGUI()
        {
            var rootMotion = target as PhysicsRootMotion;
            if (!enableEdit)
                return;

            if (Event.current.type == EventType.MouseDown)
            {
                Undo.RecordObject(rootMotion.gameObject, "Move");
                
            }
            Tools.current = Tool.None;

            var pos = Handles.PositionHandle(origin + rootMotion.Position, Quaternion.identity);
            var n = GridSystem.Instance.GridPerPixel;
            pos = new Vector3(Mathf.Round(pos.x / n) * n, Mathf.Round(pos.y / n) * n, pos.z);

            rootMotion.transform.position = pos;
            rootMotion.Position = pos - origin;
            EditorUtility.SetDirty(rootMotion);
        }
    }
}
