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
        public Script LuaScript;

        private void Awake()
        {
            UserData.RegisterType<LuaRuntime.Console>();
            UserData.CreateStatic<LuaRuntime.Console>();
            LuaScript = new Script();
            LuaScript.Globals["console"] = typeof(LuaRuntime.Console);

            LuaScript.DoFile("test");
            
        }
    }
}
