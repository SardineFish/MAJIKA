using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class EffectTriggerCollection : List<IEffectorTrigger>
{
    public T GetTrigger<T>()  where T : IEffectorTrigger
    {
        return (T)this.Where(item => item is T).FirstOrDefault();
    }
}