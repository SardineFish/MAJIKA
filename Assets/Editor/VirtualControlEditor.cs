using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEditor;
using UnityEngine.Experimental.Input.Editor;

namespace Assets.Editor
{
    [CustomEditor(typeof(VirtualJoystick), true)]
    [CanEditMultipleObjects]
    class VirtualControlEditor: UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

        }
    }
}
