using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEditor;
using System.Reflection;
using UnityEditor.SceneManagement;

namespace Assets.Editor
{
    [CustomEditor(typeof(EventResponsor))]
    [CanEditMultipleObjects]
    class EventResponsorEditor:UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            var eventResponsor = target as EventResponsor;

            eventResponsor.EventBus = EditorGUILayout.ObjectField("Event Bus", eventResponsor.EventBus, typeof(EventBus), true) as EventBus;

            EditorUtilities.DrawList("Event Responsors", eventResponsor.Responsors, (responsor) =>
            {
                EditorUtilities.DrawList(
                    responsor.Targets,
                    () => responsor.Event = EditorGUILayout.TextField("Event Name", responsor.Event),
                    (target) => EditResponsor(eventResponsor.gameObject, target));
                return responsor;
            });

            Undo.RecordObject(target, "Edit Event Responsors");
        }

        public ComponentResponsor EditResponsor(GameObject context, ComponentResponsor responsor)
        {
            if (responsor == null)
                return new ComponentResponsor();
            EditorGUILayout.BeginHorizontal();
            var components = context.GetComponents<Component>()
                .Select(cpn => cpn.GetType().Name)
                .ToList();
            var idx = EditorGUILayout.Popup(components.IndexOf(responsor.ComponentName), components.ToArray());
            if (idx < 0)
                responsor.ComponentName = "";
            else
                responsor.ComponentName = components[idx];
            var component = context.GetComponent(responsor.ComponentName);
            if (component == null)
            {
                EditorGUILayout.Popup(-1, new string[] { });
                goto End;
            }
            var methods = component.GetType().GetMethods(BindingFlags.Instance | BindingFlags.Public)
                .Select(m => m.Name)
                .ToList();
            idx = EditorGUILayout.Popup(methods.IndexOf(responsor.MethodName), methods.ToArray());
            if (idx < 0)
                responsor.MethodName = "";
            else
                responsor.MethodName = methods[idx];
        End:
            EditorGUILayout.EndHorizontal();
            return responsor;
        }
    }
}
