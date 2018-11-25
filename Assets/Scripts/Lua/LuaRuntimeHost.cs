using MoonSharp.Interpreter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace LuaHost.LuaRuntime
{
    public static class LuaRuntimeHost
    {
        static void RegisterProxy<TProxy, TTarget>() where TProxy:Proxy.ProxyBase<TTarget>, new() where TTarget:class
        {
            UserData.RegisterProxyType<TProxy, TTarget>(target => Activator.CreateInstance(typeof(TProxy), target) as TProxy);
        }
        static LuaRuntimeHost()
        {
            UserData.RegisterAssembly();
            UserData.RegisterProxyType<Proxy.GameObjectProxy, GameObject>(obj => new Proxy.GameObjectProxy(obj));
            UserData.RegisterProxyType<Proxy.GameEntityProxy, GameEntity>(obj => new Proxy.GameEntityProxy(obj));
            UserData.RegisterType<Vector3>();
            UserData.RegisterType<Vector2>();
            /*Script.GlobalOptions.CustomConverters.SetClrToScriptCustomConversion<Vector2>((script, v) => DynValue.FromObject(script, new Proxy.Vector2Wrapper(v.x, v.y)));
            Script.GlobalOptions.CustomConverters.SetScriptToClrCustomConversion(DataType.UserData, typeof(Vector2), (val) =>
            {
                var wrapper = val.UserData.Object as Proxy.Vector2Wrapper;
                if (wrapper == null)
                    return null;
                return new Vector2(wrapper.x, wrapper.y);
            });*/
        }
        public static Script GetScriptRuntime(LuaScriptHost host)
        {
            var script = new Script();
            script.Globals["console"] = typeof(Console);
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
    }
    [MoonSharpUserData]
    public class Console
    {
        public static void Log(object message) => Debug.Log(message);
        public static void Warn(object message) => Debug.LogWarning(message);
        public static void Error(object message) => Debug.LogError(message);
        public static void LogVector(Vector2 v) => Debug.Log(v);
    }
    public static class MathUtilities
    {
        public static Vector2 vec2(float x, float y) => new Vector2(x, y);
        public static Vector3 vec3(float x, float y, float z) => new Vector3(x, y);
    }
    public class UtilityHost
    {
        LuaScriptHost host;
        int timeOutID = 0;
        int intervalID = 0;
        Dictionary<int, UnityEngine.Coroutine> TimeoutCoroutine = new Dictionary<int, UnityEngine.Coroutine>();
        Dictionary<int, UnityEngine.Coroutine> IntervalCoroutine = new Dictionary<int, UnityEngine.Coroutine>();
        public UtilityHost(LuaScriptHost host)
        {
            this.host = host;
        }
        public int SetTimeout(Closure callback, float milliseconds)
        {
            TimeoutCoroutine[timeOutID]= Utility.WaitForSecond(host, () => callback.Call(), milliseconds / 1000);
            return timeOutID++;
        }
        public void RemoveTimeout(int id)
        {
            if (TimeoutCoroutine.ContainsKey(id))
            {
                host.StopCoroutine(TimeoutCoroutine[id]);
                TimeoutCoroutine.Remove(id);
            }
        }
        public int Interval(Closure callback, float milliseconds)
        {
            IntervalCoroutine[intervalID] = Utility.SetInterval(host, () => callback.Call(), milliseconds / 1000);
            return intervalID++;
        }
        public void RemoveInterval(int id)
        {
            if (IntervalCoroutine.ContainsKey(id))
            {
                host.StopCoroutine(IntervalCoroutine[id]);
                IntervalCoroutine.Remove(id);
            }
        }
    }
}