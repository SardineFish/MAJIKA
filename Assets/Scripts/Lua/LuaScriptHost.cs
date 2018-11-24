using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoonSharp.Interpreter;
using UnityEngine;

namespace LuaHost
{
    public class LuaScriptHost : Singleton<LuaScriptHost>
    {
        public TextAsset Script;

        [NonSerialized]
        public Script LuaScript;

        private void Awake()
        {
            LuaScript = LuaRuntime.LuaRuntimeHost.GetScriptRuntime(this);
            
        }

        private void Start()
        {
            if (Script)
                LuaScript.DoString(Script.text);
        }

        public void RunScript(TextAsset script)
        {
            LuaScript.DoString(script.text);
        }
    }

    public class HostBase
    {
        protected LuaScriptHost host;
        [MoonSharpHidden]
        protected HostBase(LuaScriptHost host)
        {
            this.host = host;
        }
    }
}
