using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;

namespace Assets.Editor
{
    [CustomAttributeEditor(typeof(ReadOnlyAttribute))]
    class ReadOnlyEditor : AttributeEditor
    {
        public override void OnEdit(MemberInfo member, CustomEditorAttribute attr)
        {
            var readonlyAttr = attr as ReadOnlyAttribute;
            if (readonlyAttr == null)
                return;

            string value = "<error>";
            if (member.MemberType == MemberTypes.Property)
                value = (member as PropertyInfo).GetValue(target).ToString();
            else if (member.MemberType == MemberTypes.Field)
                value = (member as FieldInfo).GetValue(target).ToString();
            EditorUtilities.Horizontal(() =>
            {
                EditorGUILayout.LabelField(readonlyAttr.Label == "" ? member.Name : readonlyAttr.Label);
                EditorGUILayout.LabelField(value.ToString());
            });

        }
    }
}
