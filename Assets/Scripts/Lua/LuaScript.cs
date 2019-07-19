using UnityEngine;
using System.Collections;
using System;

namespace MAJIKA.Lua
{
    [Serializable]
    public class LuaScript : ScriptableObject
    {
        [HideInInspector]
        [SerializeField]
        string m_code = "";
        public string text
        {
            get => m_code;
            set => m_code = value;
        }
        public LuaScript()
        {
        }

        public LuaScript(string code)
        {
            this.text = code;
        }
    }
}