using System;
using UnityEngine;
using UnityEditor;
using System.Linq;
namespace Assets.Editor
{
    public class KeySetting
    {
        bool editing = false;
        KeyCode inputValue;
        
        public KeyCode Edit(string label, KeyCode value)
        {
            if(!editing)
                inputValue = value;
            else
            {
                Enum.GetValues(typeof(KeyCode)).Cast<KeyCode>().ForEach((key) =>
                {
                    if (Input.GetKeyDown(key))
                    {
                        Debug.Log(key);
                    }
                });
                if (Event.current.type == EventType.KeyDown)
                {
                    inputValue = Event.current.keyCode;
                    Event.current.Use();
                    editing = false;
                }
                else if (Event.current.type == EventType.MouseDown)
                {
                    inputValue = (KeyCode)Enum.Parse(typeof(KeyCode), "Mouse" + Event.current.button.ToString());
                    Event.current.Use();
                    editing = false;
                }
            }
            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField(label, GUILayout.Width(60));
            inputValue = (KeyCode)EditorGUILayout.EnumPopup(inputValue,GUILayout.Width(140));
            editing = GUILayout.Toggle(editing, "Set", "Button");
            EditorGUILayout.EndHorizontal();
            return inputValue;
        }
    }
}