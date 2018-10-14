using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SardineFish.Unity.FSM
{
    [System.AttributeUsage(AttributeTargets.Method, Inherited = true, AllowMultiple = false)]
    sealed class StateUpdateAttribute : Attribute
    {
        public object state;
        public StateUpdateAttribute(object state)
        {
            this.state = state;
        }
    }
}
