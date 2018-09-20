using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEditor;

namespace Assets.Editor
{
    [CustomEditor(typeof(InputManager))]
    [CanEditMultipleObjects]
    public class InputManagerEditor:UnityEditor.Editor
    {
        KeySetting jumpKey = new KeySetting();
        public override void OnInspectorGUI()
        {
            var input = target as InputManager;
            input.KeyJump = jumpKey.Edit("Jump", input.KeyJump);
        }
    }
}
