using System;
using System.Collections;
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
            LuaScript.Globals.Get("start").Function?.Call();
        }

        private void Update()
        {
            LuaScript.Globals.Get("update").Function?.Call(Time.deltaTime);
        }

        protected virtual void Awake()
        {
            InitRuntime();
            if (Script)
                LuaScript.DoString(Script.text);
            LuaScript.Globals.Get("awake").Function?.Call();
        }

        public void RunScript(TextAsset script)
        {
            LuaScript.DoString(script.text);
            LuaScript.Globals.Get("awake").Function?.Call();
            LuaScript.Globals.Get("start").Function?.Call();
        }

        public void ReStart()
        {
            StopAllCoroutines();
            LuaScript.DoString(Script.text);
            LuaScript.Globals.Get("awake").Function?.Call();
            LuaScript.Globals.Get("start").Function?.Call();
        }

        public static Script CreateScriptRuntime(LuaScriptHost host)
        {
            host.CoroutineManager = new LuaCoroutineManager(host);
            var script = new Script();
            script.Globals["_host"] = host;
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
            script.Globals["utility"] = utility;
            script.Globals["camera"] = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
            return script;
        }
        static void InitRuntimeEnvironment()
        {
            UserData.RegisterAssembly();
            UserData.RegisterProxyType<LuaScriptProxy, LuaScriptHost>(obj => new LuaScriptProxy(obj));
            UserData.RegisterProxyType<Proxy.GameObjectProxy, GameObject>(obj => new Proxy.GameObjectProxy(obj));
            UserData.RegisterProxyType<Proxy.GameEntityProxy, GameEntity>(obj => new Proxy.GameEntityProxy(obj));
            UserData.RegisterProxyType<Proxy.CoroutineProxy, UnityEngine.Coroutine>(obj => new Proxy.CoroutineProxy(obj));
            UserData.RegisterProxyType<Proxy.CameraProxy, Camera>(obj => new Proxy.CameraProxy(obj));
            UserData.RegisterType<UtilityHost>();
            UserData.RegisterType<Vector3>();
            UserData.RegisterType<Vector2>();
            UserData.RegisterType<Threat>();
            UserData.RegisterType<Utility.CallbackYieldInstruction>();
            UserData.RegisterType<YieldInstruction>();
            UserData.RegisterType<Time>();
        }
    }

    class LuaScriptProxy : Proxy.ProxyBase<LuaScriptHost>
    {
        public LuaScriptProxy(LuaScriptHost target) : base(target)
        {
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

        public IEnumerator Co(MoonSharp.Interpreter.Coroutine co)
        {
            while(co.State != CoroutineState.Dead)
            {
                var val = co.Resume();
                /*if (!val.IsNil())
                    Debug.Log(val.ToObject());*/
                yield return val.ToObject();
            }
        }
        
        public UnityEngine.Coroutine StartCoroutine(Closure closure)
        {
            return Host.StartCoroutine(Co(closure.OwnerScript.CreateCoroutine(closure).Coroutine));
        }
        public UnityEngine.Coroutine StartCoroutine(MoonSharp.Interpreter.Coroutine coroutine)
            => Host.StartCoroutine(coroutine.AsUnityCoroutine());
        public void StopCoroutine(UnityEngine.Coroutine coroutine)
            => Host.StopCoroutine(coroutine);
    }
}
