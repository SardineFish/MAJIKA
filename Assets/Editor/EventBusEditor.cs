using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEditor;

namespace Assets.Editor
{
    [CustomEditor(typeof(EventBus))]
    [CanEditMultipleObjects]
    class EventBusEditor : UnityEditor.Editor
    {
        string eventName = "";
        public override void OnInspectorGUI()
        {
            var eventBus = target as EventBus;
            base.OnInspectorGUI();
            EditorGUILayout.BeginHorizontal();
            eventName = EditorGUILayout.TextField("Event Name", eventName);
            if (GUILayout.Button("Dispatch"))
            {
                eventBus.Dispatch(eventName);
            }
            EditorGUILayout.EndHorizontal();
        }
    }
}
