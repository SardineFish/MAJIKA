using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEditor;
using System.Reflection;

namespace Assets.Editor
{
    [CustomEditor(typeof(MonoBehaviour), true)]
    class EditorHelper: UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            target.GetType().GetMethods()
                .Where(method => method.GetCustomAttributes(typeof(EditorButtonAttribute), true).FirstOrDefault() != null)
                .ForEach(method =>
                {
                    var attr = method.GetCustomAttributes(typeof(EditorButtonAttribute), true).FirstOrDefault() as EditorButtonAttribute;
                    var label = attr.Label;
                    if (label == "")
                        label = method.Name;
                    if(GUILayout.Button(label))
                        method.Invoke(target, new object[] { });
                });
            target.GetType().GetMembers(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                .Where(member => member.MemberType == MemberTypes.Field || member.MemberType == MemberTypes.Property)
                .Where(member => member.GetCustomAttributes(typeof(ReadOnlyAttribute), true).FirstOrDefault() != null)
                .ForEach(member =>
                {
                    var attr = member.GetCustomAttributes(typeof(ReadOnlyAttribute), true).FirstOrDefault() as ReadOnlyAttribute;
                    var label = attr.Label;
                    if (label == "")
                        label = member.Name;
                    var value = (member as FieldInfo)?.GetValue(target)?.ToString() ?? (member as PropertyInfo).GetValue(target)?.ToString();
                    if (value != null)
                    {
                        EditorUtilities.Horizontal(() =>
                        {
                            EditorGUILayout.PrefixLabel(label);
                            EditorGUILayout.LabelField(value);
                        });
                    }
                });
        }
    }
}