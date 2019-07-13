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

            EditorUtilities.DrawList(eventResponsor.Responsors)
                .Header("Event Responsors")
                .Item((responsor) =>
                {
                    EditorUtilities.DrawList(responsor.Handlers)
                        .Header(() => responsor.Event = EditorGUILayout.TextField("Event Name", responsor.Event))
                        .Item((handler) => EditResponsor(eventResponsor.gameObject, handler, ()=> Undo.RecordObject(target, "Edit Event Responsors")))
                        .Render();
                    return responsor;
                })
                .Render();

            Undo.RecordObject(target, "Edit Event Responsors");
        }

        public ComponentEventHandler EditResponsor(GameObject context, ComponentEventHandler responsor, Action callback)
        {
            if (responsor == null)
                return new ComponentEventHandler();
            EditorUtilities.Verticle(() =>
            {
                if (GUILayout.Button($"{responsor.ComponentName}/{responsor.MethodName}", "TextField"))
                {
                    EditorUtilities.PopupMenu(context.GetComponents<Component>()
                        .Select(component => new PopupMenuItem()
                        {
                            Name = component.GetType().Name,
                            Children = component.GetType().GetMethods(BindingFlags.Instance | BindingFlags.Public)
                                .Where(m => !m.IsSpecialName)
                                .Select(method => new PopupMenuItem(method.Name))
                                .ToArray()
                        }).ToArray(), $"{responsor.ComponentName}/{responsor.MethodName}", (selected) =>
                         {
                             responsor.ComponentName = selected.Split('/')[0];
                             responsor.MethodName = selected.Split('/')[1];
                             callback();
                         });

                }
            });
            /*
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
                .Where(m => !m.IsSpecialName)
                .Select(m => m.Name)
                .ToList();
            idx = EditorGUILayout.Popup(methods.IndexOf(responsor.MethodName), methods.ToArray());
            if (idx < 0)
                responsor.MethodName = "";
            else
                responsor.MethodName = methods[idx];
        End:
            EditorGUILayout.EndHorizontal();*/
            return responsor;
        }
    }
}
