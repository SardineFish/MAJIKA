using MoonSharp.Interpreter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace LuaHost.LuaRuntime
{
    [MoonSharpUserData]
    public class Console
    {
        public static void Log(object message) => Debug.Log(message);
        public static void Warn(object message) => Debug.LogWarning(message);
        public static void Error(object message) => Debug.LogError(message);
    }
}
