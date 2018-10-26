using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEditor;

namespace Assets.Editor
{
    [CustomPropertyDrawer(typeof(EventResponse))]
    public class EventResponsorDrawer: PropertyDrawer
    {
        private static class Styles
        {
            public static GUIStyle borderRect = new GUIStyle("Label");
            public static GUIStyle columnHeaderLabel = new GUIStyle(EditorStyles.toolbar);

            static Styles()
            {
                borderRect.border = new RectOffset(3, 3, 3, 3);

                columnHeaderLabel.alignment = TextAnchor.MiddleLeft;
                columnHeaderLabel.fontStyle = FontStyle.Bold;
                columnHeaderLabel.padding.left = 10;
                columnHeaderLabel.border = new RectOffset(1, 1, 1, 1);
            }
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            var responsors = property.FindPropertyRelative("Responsors");
            var rect = position;
            EditorGUI.BeginProperty(rect, label, property);

            var labelRect = position;
            //EditorGUI.LabelField(labelRect, GUIContent.none, Styles.borderRect);
            var headerRect = new Rect(labelRect.x + 1, labelRect.y + 1, labelRect.width - 2, labelRect.height - 2);
            //EditorGUI.LabelField(headerRect, label, Styles.columnHeaderLabel);
            //EditorGUILayout.LabelField(label, Styles.columnHeaderLabel);

            
            var buttonRemoveRect = labelRect;
            //buttonRemoveRect.x = labelRect.width - (EditorGUIUtility.singleLineHeight + EditorGUIUtility.standardVerticalSpacing);
            buttonRemoveRect.width = EditorGUIUtility.singleLineHeight + EditorGUIUtility.standardVerticalSpacing;
            if (GUI.Button(buttonRemoveRect, EditorGUIUtility.IconContent("Toolbar Minus"), GUIStyle.none))
            {

            }
            var eventNameRect = labelRect;
            eventNameRect.y += EditorGUIUtility.singleLineHeight;
            eventNameRect.height = EditorGUIUtility.singleLineHeight;
            eventNameRect.width -= 2*(EditorGUIUtility.singleLineHeight + EditorGUIUtility.standardVerticalSpacing);
            EditorGUI.PropertyField(eventNameRect, property.FindPropertyRelative("Event"));

            var buttonAddRect = eventNameRect;
            buttonAddRect.x = labelRect.width - (EditorGUIUtility.singleLineHeight + EditorGUIUtility.standardVerticalSpacing);
            buttonAddRect.width = EditorGUIUtility.singleLineHeight + EditorGUIUtility.standardVerticalSpacing;
            var plusIconContext = EditorGUIUtility.IconContent("Toolbar Plus");
            if (GUI.Button(buttonAddRect, plusIconContext, GUIStyle.none))
            {
                responsors.InsertArrayElementAtIndex(responsors.arraySize);
            }

            /*EditorGUILayout.BeginVertical(new GUIStyle(EditorStyles.toolbarPopup));
            EditorGUILayout.TextField("EventName","");

            EditorGUILayout.EndVertical();*/

            EditorGUI.EndProperty();
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return EditorGUIUtility.singleLineHeight * 5;
        }
    }
}
