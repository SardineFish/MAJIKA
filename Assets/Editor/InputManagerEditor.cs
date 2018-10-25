using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEditor;
using System.Reflection;
using UnityEngine.Experimental.Input;
/*
namespace Assets.Editor
{
    [CustomEditor(typeof(InputManager))]
    [CanEditMultipleObjects]
    public class InputManagerEditor:UnityEditor.Editor
    {
        KeySetting jumpKey = new KeySetting();
        KeySetting[] keySettings = new KeySetting[0];
        bool first = false;
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            var input = target as InputManager;
            var inputList = input.GetType().GetFields().Where(field => field.FieldType == typeof(KeyCode)).ToArray();
            Array.Resize(ref keySettings, inputList.Length);
            for(var i = 0; i < keySettings.Length; i++)
            {
                if (keySettings[i] == null)
                {
                    keySettings[i] = new KeySetting();
                }
                inputList[i].SetValue(input, keySettings[i].Edit(inputList[i].Name, (KeyCode)inputList[i].GetValue(input)));
            }
            var skillKeysProp = serializedObject.FindProperty("SkillActions");
            EditorUtilities.DrawFoldList("Skil Keys", true, input.SkillActions.Count, (i) =>
            {
                EditorGUILayout.PropertyField(skillKeysProp.GetArrayElementAtIndex(i));
                 
             },()=>
             {
                 var action = input.SkillActions.Last();
                 typeof(InputAction).GetField("m_Name", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(action, $"SkillKey{input.SkillActions.Count}");
                 input.SkillActions.Add(input.SkillActions.Last());
             });
            UnityEditor.EditorUtility.SetDirty(input);
            
            //input.KeyJump = jumpKey.Edit("Jump", input.KeyJump);
        }
    }
}
*/