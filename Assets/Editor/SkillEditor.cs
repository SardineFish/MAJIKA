using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEditor;

namespace Assets.Editor
{
    [CustomEditor(typeof(Skill))]
    [CanEditMultipleObjects]
    class SkillEditor:UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            var skill = target as Skill;
            base.OnInspectorGUI();
            EditorUtilities.DrawList("Effects", skill.Effects, (effect) =>
              {
                  EditorGUILayout.BeginHorizontal(GUILayout.Height(EditorGUIUtility.singleLineHeight + EditorGUIUtility.standardVerticalSpacing));
                  effect.Effect = EditorGUILayout.ObjectField(effect.Effect, typeof(Effect), true) as Effect;
                  EditorGUILayout.LabelField("x", GUILayout.Width(EditorGUIUtility.singleLineHeight));
                  effect.Strength = EditorGUILayout.FloatField(effect.Strength);
                  EditorGUILayout.EndHorizontal();
                  return effect;
              });
            EditorUtility.SetDirty(skill);
        }
    }
}
