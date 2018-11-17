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

            Script.GlobalOptions.CustomConverters.SetClrToScriptCustomConversion<Vector2>((script, v) => DynValue.FromObject(script, new Proxy.Vector2Wrapper(v.x, v.y)));
            Script.GlobalOptions.CustomConverters.SetScriptToClrCustomConversion(DataType.UserData, typeof(Vector2), (val) =>
            {
                var wrapper = val.UserData.Object as Proxy.Vector2Wrapper;
                if (wrapper == null)
                    return Vector2.zero;
                return new Vector2(wrapper.x, wrapper.y);
            });
        }
        public static Script GetScriptRuntime()
        {
            var script = new Script();
            script.Globals["console"] = typeof(Console);
            script.Globals["scene"] = new SceneHost();
            script.Globals["resources"] = new ResourcesHost();
            script.Globals["vec2"] = (Func<float, float, Vector2>)MathUtilities.vec2;
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
    }
}
