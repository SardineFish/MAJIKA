using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEditor;
using System.Reflection;

namespace Assets.Editor
{
    [CustomEditor(typeof(InputManager))]
    [CanEditMultipleObjects]
    public class InputManagerEditor:UnityEditor.Editor
    {
        KeySetting jumpKey = new KeySetting();
        KeySetting[] keySettings = new KeySetting[0];
        public override void OnInspectorGUI()
        { 
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
            UnityEditor.EditorUtility.SetDirty(input);
            //input.KeyJump = jumpKey.Edit("Jump", input.KeyJump);
        }
    }
}
