using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SardineFish.Unity.FSM
{
    public abstract class State:IState<State>
    {
        public virtual bool OnEnter(State lastState)
        {
            return true;
        }
        public virtual void OnUpdate() { }
        public virtual bool OnExit(State nextState)
        {
            return true;
        }
    }
}
