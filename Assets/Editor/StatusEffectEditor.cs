using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEditor;

namespace Assets.Editor
{
    [CustomAttributeEditor(typeof(MAJIKA.Utils.StatusEffectAttribute))]
    public class StatusEffectEditor : AttributeEditor
    {
        public override void OnEdit(MemberInfo member, CustomEditorAttribute attr)
        {
            var effectList = (member as FieldInfo).GetValue(target);
            if(effectList is List<EffectInstance>)
            {
                EditorUtilities.DrawList(effectList as List<EffectInstance>)
                    .Header(member.Name)
                    .Item((effect) =>
                    {
                        EditorGUILayout.BeginHorizontal(GUILayout.Height(EditorGUIUtility.singleLineHeight + EditorGUIUtility.standardVerticalSpacing));
                        effect.Effect = EditorGUILayout.ObjectField(effect.Effect, typeof(Effect), true) as Effect;
                        EditorGUILayout.LabelField("x", GUILayout.Width(EditorGUIUtility.singleLineHeight));
                        effect.Strength = EditorGUILayout.FloatField(effect.Strength);
                        EditorGUILayout.EndHorizontal();
                        return effect;
                    })
                    .Render();
            }
            else if (effectList is EffectInstance[])
            {
                EditorUtilities.DrawArray(member.Name, effectList as EffectInstance[], (effect) =>
                {
                    EditorGUILayout.BeginHorizontal(GUILayout.Height(EditorGUIUtility.singleLineHeight + EditorGUIUtility.standardVerticalSpacing));
                    effect.Effect = EditorGUILayout.ObjectField(effect.Effect, typeof(Effect), true) as Effect;
                    EditorGUILayout.LabelField("x", GUILayout.Width(EditorGUIUtility.singleLineHeight));
                    effect.Strength = EditorGUILayout.FloatField(effect.Strength);
                    EditorGUILayout.EndHorizontal();
                    return effect;
                });
            }
            Undo.RecordObject(target, "Edit effects.");
        }
    }
}
