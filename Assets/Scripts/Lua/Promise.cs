using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoonSharp.Interpreter;

namespace LuaHost
{
    [MoonSharpUserData]
    public class Promise
    {
        private Action<Action> executor;
        private Func<Promise> callback;
        private Promise thenPromise;
        [MoonSharpHidden]
        public Promise()
        {
        }
        [MoonSharpHidden]
        public Promise(Action<Action> executor, LuaScriptHost host)
        {
            this.executor = executor;
            host.StartCoroutine(Execute());
        }
        private IEnumerator Execute()
        {
            executor.Invoke(Resolve);
            yield break;
        }
        private void Resolve()
        {
            if (callback == null)
                return;
            var promise = callback();
            if (promise != null && thenPromise != null)
                promise.Then(() => thenPromise.Resolve());
        }
        public Promise Then(Closure closure)
        {
            this.callback = () =>
            {
                var promise = closure?.Call().ToObject<Promise>();
                return promise;
            };
            return thenPromise = new Promise();
        }
        public void Then(Action callback)
        {
            this.callback = () =>
            {
                callback();
                return null;
            };
        }
        public Promise Then(Func<Promise> callback)
        {
            this.callback = callback;
            return thenPromise = new Promise();
        }
    }
}
