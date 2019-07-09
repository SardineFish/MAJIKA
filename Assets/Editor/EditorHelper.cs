using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEditor;
using System.Reflection;

[CustomEditor(typeof(MonoBehaviour), true)]
class EditorHelper : UnityEditor.Editor
{
    Dictionary<Type, AttributeEditor> attributeEditorInstances = new Dictionary<Type, AttributeEditor>();
    MemberInfo[] members;
    public EditorHelper() : base()
    {
        if (!CustomEditorHelper.Loaded)
            CustomEditorHelper.Reload();
    }
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        if (members == null)
            members = target.GetType().GetMembers(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
            .Where(member => member.MemberType == MemberTypes.Field
                || member.MemberType == MemberTypes.Property || (member.MemberType == MemberTypes.Method && !(member as MethodInfo).IsSpecialName))
            .ToArray();

        for (var i = 0; i < members.Length; i++)
        {
            var member = members[i];
            /*if (member.MemberType == MemberTypes.Method)
            {
                var method = member as MethodInfo;
                var attr = method.GetCustomAttributes(typeof(EditorButtonAttribute), true).FirstOrDefault() as EditorButtonAttribute;
                var label = attr.Label;
                if (label == "")
                    label = method.Name;
                if (GUILayout.Button(label))
                    method.Invoke(target, new object[] { });
            }
            else if (member.MemberType == MemberTypes.Field)
            {

            }
            else if (member.MemberType == MemberTypes.Property)
            {

            }*/

            var attr = member.GetCustomAttribute<CustomEditorAttribute>(true);
            if (attr is null)
                continue;
            var attrType = attr.GetType();
            if (!attributeEditorInstances.ContainsKey(attrType))
            {
                var editorType = CustomEditorHelper.CustomAttributeEditors[attrType];
                if (editorType is null)
                    continue;

                var editor = Activator.CreateInstance(editorType) as AttributeEditor;
                editor.target = target;
                attributeEditorInstances[attrType] = editor;
            }
            attributeEditorInstances[attrType].OnEdit(member, attr);
        }

        /*
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
            });*/
    }
}

public abstract class AttributeEditor
{
    public UnityEngine.Object target;
    public abstract void OnEdit(MemberInfo member, CustomEditorAttribute attr);
}


public static class CustomEditorHelper
{
    public static bool Loaded = false;
    public static Dictionary<Type, Type> CustomAttributeEditors = new Dictionary<Type, Type>();
    public static void Reload()
    {
        Loaded = true;
        typeof(CustomEditorHelper).Assembly.GetTypes()
            .Where(type => type.IsSubclassOf(typeof(AttributeEditor)))
            .Where(type => type.GetCustomAttribute<CustomAttributeEditorAttribute>() != null)
            .ForEach(type =>
            {
                CustomAttributeEditors[type.GetCustomAttribute<CustomAttributeEditorAttribute>().type] = type;
            });

    }
}

[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
public class CustomAttributeEditorAttribute : Attribute
{
    public Type type { get; private set; }
    public CustomAttributeEditorAttribute(Type type) : base()
    {
        this.type = type;
    }
}