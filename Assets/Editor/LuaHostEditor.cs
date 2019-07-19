using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEditor;
using MAJIKA.Lua;

namespace Assets.Editor
{
    [CanEditMultipleObjects]
    [CustomEditor(typeof(LuaScriptHost), true)]
    class LuaHostEditor:UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            var luaHost = target as LuaScriptHost;
            EditorGUILayout.Space();
            if (GUILayout.Button("Run"))
            {
                luaHost.CoroutineManager?.Reset();
                if (luaHost.InitialScript)
                    luaHost.RunScript(luaHost.InitialScript);
                luaHost.RunScript(luaHost.Script);

            }
        }
    }
}
