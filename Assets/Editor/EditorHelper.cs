using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEditor;
using System.Reflection;

[CustomEditor(typeof(MonoBehaviour), true)]
[CanEditMultipleObjects]
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

        Undo.RecordObject(target, $"Edit {target.GetType().Name}");
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