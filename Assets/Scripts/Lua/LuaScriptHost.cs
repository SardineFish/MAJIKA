using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LuaHost.LuaRuntime;
using MoonSharp.Interpreter;
using UnityEngine;

namespace LuaHost
{
    public class LuaScriptHost : MonoBehaviour
    {
        public TextAsset Script;

        [NonSerialized]
        public Script LuaScript;

        public virtual void InitRuntime()
        {
            InitRuntimeEnvironment();
            LuaScript = CreateScriptRuntime(this);
        }

        protected virtual void Start()
        {
            if (Script)
                LuaScript.DoString(Script.text);
        }

        protected virtual void Awake()
        {
            InitRuntime();
        }

        public void RunScript(TextAsset script)
        {
            LuaScript.DoString(script.text);
        }

        public static Script CreateScriptRuntime(LuaScriptHost host)
        {
            var script = new Script();
            script.Globals["console"] = typeof(LuaRuntime.Console);
            script.Globals["scene"] = new SceneHost();
            script.Globals["resources"] = new ResourcesHost();
            script.Globals["game"] = new GameHost(host);
            script.Globals["vec2"] = (Func<float, float, Vector2>)MathUtilities.vec2;
            script.Globals["vec3"] = (Func<float, float, float, Vector3>)MathUtilities.vec3;
            var utility = new UtilityHost(host);
            script.Globals["timeout"] = (Func<Closure, float, int>)utility.SetTimeout;
            script.Globals["interval"] = (Func<Closure, float, int>)utility.Interval;
            script.Globals["removeTimeout"] = (Action<int>)utility.RemoveTimeout;
            script.Globals["removeInterval"] = (Action<int>)utility.RemoveInterval;
            return script;
        }
        static void InitRuntimeEnvironment()
        {
            UserData.RegisterAssembly();
            UserData.RegisterProxyType<Proxy.GameObjectProxy, GameObject>(obj => new Proxy.GameObjectProxy(obj));
            UserData.RegisterProxyType<Proxy.GameEntityProxy, GameEntity>(obj => new Proxy.GameEntityProxy(obj));
            UserData.RegisterType<Vector3>();
            UserData.RegisterType<Vector2>();
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
