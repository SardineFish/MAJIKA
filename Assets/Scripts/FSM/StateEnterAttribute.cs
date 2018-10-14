using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SardineFish.Unity.FSM
{
    [System.AttributeUsage(AttributeTargets.Method, Inherited = true, AllowMultiple = false)]
    sealed class StateEnterAttribute : Attribute
    {
        public object state;
        public StateEnterAttribute(object state)
        {
            this.state = state;
        }
    }
}
