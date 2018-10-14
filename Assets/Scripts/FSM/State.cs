using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SardineFish.Unity.FSM
{
    public abstract class State
    {
        public virtual bool Enter(State lastState)
        {
            return true;
        }
        public virtual void Update() { }
        public virtual bool Exit(State nextState)
        {
            return true;
        }
    }
}
