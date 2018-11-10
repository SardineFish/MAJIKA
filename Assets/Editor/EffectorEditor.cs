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
    [CustomEditor(typeof(EntityEffector))]
    class EffectorEditor : UnityEditor.Editor
    {
        Effect testEffect;
        float testStrength;
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            var effector = target as EntityEffector;

            EditorGUILayout.LabelField("Effects:");
            EditorUtilities.Verticle(EditorUtilities.Styles.Indent, () =>
             {
                 foreach(var effect in effector.Effects)
                 {
                     EditorGUILayout.LabelField($"{effect.Effect.name} x {effect.Strength}");
                 }
             });

            EditorGUILayout.Space();
            EditorGUILayout.BeginHorizontal(GUILayout.Height(EditorGUIUtility.singleLineHeight + EditorGUIUtility.standardVerticalSpacing));
            testEffect = EditorGUILayout.ObjectField(testEffect, typeof(Effect), true) as Effect;
            EditorGUILayout.LabelField("x", GUILayout.Width(EditorGUIUtility.singleLineHeight));
            testStrength = EditorGUILayout.FloatField(testStrength);
            EditorGUILayout.EndHorizontal();

            if (GUILayout.Button("Add Effect"))
                effector.AddEffect(new EffectInstance() { Effect = testEffect, Strength = testStrength }, null);
        }
    }
}
