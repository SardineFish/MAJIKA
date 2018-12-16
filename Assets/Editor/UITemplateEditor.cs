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
    [CustomEditor(typeof(UITemplate))]
    public class UITemplateEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            var template = target as UITemplate;

            for(var i=0;i<template.transform.childCount;i++)
            {
                if (!template.transform.GetChild(i).GetComponent<UITemplate>())
                    template.transform.GetChild(i).gameObject.AddComponent<UITemplate>();
            }
            EditorUtilities.DrawList("Bindings:", template.Bindings, (bind) =>
              {
                  bind.PathSource = EditorGUILayout.TextField("BindSource", bind.PathSource);
                  EditorGUILayout.LabelField("TargetPath");
                  EditorGUILayout.BeginHorizontal();

                  // Get components and show as a drop box.
                  var components = template.GetComponents<Component>();
                  var paths = bind.PathTemplate.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
                  var componentName = paths.Length > 0 ? paths[0] : "";
                  var nameList = components
                      .Where(component => component)
                      .Select(component => component.GetType().Name)
                      .ToList();
                  var idx = nameList.IndexOf(componentName);
                  //idx = idx < 0 ? 0 : idx;
                  if (idx < 0)
                  {
                      idx = 0;
                      componentName = nameList[0];
                      bind.PathTemplate = nameList[0] + ".";
                  }

                  idx = EditorGUILayout.Popup(idx, nameList.ToArray());
                  bind.PathTemplate = nameList[idx] + "." + EditorGUILayout.TextField(bind.PathTemplate.Substring(componentName.Length + 1));
                  EditorGUILayout.EndHorizontal();
                  EditorGUILayout.Space();
                  EditorGUILayout.Space();
                  return bind;
              });
            if (GUILayout.Button("Add"))
            {
                template.Bindings.Add(new BindingOption());
            }
            template.DataSource = EditorGUILayout.ObjectField("Data Source", template.DataSource as UnityEngine.Object, typeof(UnityEngine.Object), true);
            EditorUtility.SetDirty(target);
        }
    }
}
