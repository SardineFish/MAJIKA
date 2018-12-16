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