using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SardineFish.Unity.FSM
{
    public class SimpleFSM<T>
    {
        public T State { get; private set; }
        private object stateTarget;
        private bool hasFirstState = false;
        private Dictionary<T, MethodInfo> enterHandler = new Dictionary<T, MethodInfo>();
        private Dictionary<T, MethodInfo> updateHandler = new Dictionary<T, MethodInfo>();
        private Dictionary<T, MethodInfo> exitHandler = new Dictionary<T, MethodInfo>();
        public SimpleFSM(object obj) : base()
        {
            stateTarget = obj;
            // Init state enter
            obj.GetType().GetMethods(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance)
                .Where(method => method.GetCustomAttribute<StateEnterAttribute>() != null)
                .ForEach(method =>
                {
                    var attr = method.GetCustomAttribute<StateEnterAttribute>();
                    enterHandler[(T)attr.state] = method;
                });

            // Init state update
            obj.GetType().GetMethods(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance)
                .Where(method => method.GetCustomAttribute<StateUpdateAttribute>() != null)
                .ForEach(method =>
                {
                    var attr = method.GetCustomAttribute<StateUpdateAttribute>();
                    updateHandler[(T)attr.state] = method;
                });

            // Init state exit
            obj.GetType().GetMethods(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance)
                .Where(method => method.GetCustomAttribute<StateExitAttribute>() != null)
                .ForEach(method =>
                {
                    var attr = method.GetCustomAttribute<StateExitAttribute>();
                    enterHandler[(T)attr.state] = method;
                });
        }
        public SimpleFSM(object target, T initialState)
        {
            State = initialState;
            hasFirstState = false;
        }

        public bool ChangeState(T nextState)
        {
            if (!hasFirstState)
            {
                hasFirstState = true;
            }
            else if (!Convert.ToBoolean(exitHandler[State]?.Invoke<object>(stateTarget, nextState)))
            {
                return false;
            }
            if (!Convert.ToBoolean(enterHandler[nextState]?.Invoke<object>(stateTarget, nextState)))
                return false;

            State = nextState;
            return true;
        }
    }

    internal static class Utilities
    {
        public static T Invoke<T>(this MethodInfo method, object target, params object[] args)
        {
            return (T)method.Invoke(target, args);
        }
    }
}
