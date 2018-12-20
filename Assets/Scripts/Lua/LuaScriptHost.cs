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
        public LuaCoroutineManager CoroutineManager;

        public virtual void InitRuntime()
        {
            InitRuntimeEnvironment();
            LuaScript = CreateScriptRuntime(this);
        }

        protected virtual void Start()
        {
            if (Script)
                LuaScript.DoString(Script.text);

            LuaScript.Globals.Get("start").Function?.Call();
        }

        private void Update()
        {
            LuaScript.Globals.Get("update").Function?.Call(Time.deltaTime);
        }

        protected virtual void Awake()
        {
            InitRuntime();
        }

        public void RunScript(TextAsset script)
        {
            LuaScript.DoString(script.text);
            LuaScript.Globals.Get("start").Function?.Call();
        }

        public static Script CreateScriptRuntime(LuaScriptHost host)
        {
            host.CoroutineManager = new LuaCoroutineManager(host);
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
            script.Globals["waitForSeconds"] = (Func<float, YieldInstruction>)utility.WaitForSeconds;
            script.Globals["Time"] = typeof(Time);
            script.Globals["entity"] = host.GetComponent<GameEntity>();
            script.Globals["startCoroutine"] = (Func<Closure, UnityEngine.Coroutine>)host.CoroutineManager.StartCoroutine;
            script.Globals["stopCoroutine"] = (Action<UnityEngine.Coroutine>)host.CoroutineManager.StopCoroutine;
            return script;
        }
        static void InitRuntimeEnvironment()
        {
            UserData.RegisterAssembly();
            UserData.RegisterProxyType<Proxy.GameObjectProxy, GameObject>(obj => new Proxy.GameObjectProxy(obj));
            UserData.RegisterProxyType<Proxy.GameEntityProxy, GameEntity>(obj => new Proxy.GameEntityProxy(obj));
            UserData.RegisterProxyType<Proxy.CoroutineProxy, UnityEngine.Coroutine>(obj => new Proxy.CoroutineProxy(obj));
            UserData.RegisterType<Vector3>();
            UserData.RegisterType<Vector2>();
            UserData.RegisterType<YieldInstruction>();
            UserData.RegisterType<Time>();
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

    public class LuaCoroutineManager
    {
        LuaScriptHost Host;
        public LuaCoroutineManager(LuaScriptHost host)
        {
            Host = host;
        }

        public void Reset()
            => Host.StopAllCoroutines();

        public UnityEngine.Coroutine StartCoroutine(Closure closure)
            => Host.StartCoroutine(closure.OwnerScript.CreateCoroutine(closure).Coroutine.AsUnityCoroutine());
        public UnityEngine.Coroutine StartCoroutine(MoonSharp.Interpreter.Coroutine coroutine)
            => Host.StartCoroutine(coroutine.AsUnityCoroutine());
        public void StopCoroutine(UnityEngine.Coroutine coroutine)
            => Host.StopCoroutine(coroutine);
    }
}
