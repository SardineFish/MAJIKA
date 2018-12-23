using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEditor;

namespace Assets.Editor
{
    [CustomPropertyDrawer(typeof(Locker))]
    class LockerDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            var locker = fieldInfo.GetValue(property.serializedObject.targetObject) as Locker;
            EditorGUI.Toggle(position, label, locker.Locked);
        }
    }
}
