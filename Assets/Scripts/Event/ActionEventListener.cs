using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ActionEventListener<T> : EventListenerBase
{
    public Action<T> Callback;
    public ActionEventListener(Action<T> callback)
    {
        Callback = callback;
    }

    public override void Invoke(params object[] args)
    {
        if (args.Length <= 0)
            Callback?.Invoke(default(T));
        else
            Callback?.Invoke((T)args[0]);
    }
}