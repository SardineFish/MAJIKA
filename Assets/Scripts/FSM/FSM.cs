using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SardineFish.Unity.FSM
{
    public class FSM<T> where T:State
    {
        public T State { get; private set; }
        public FSM()
        {
            State = null;
        }
        public FSM(T initialState) : this()
        {
            State = initialState;
        }

        public bool ChangeState(T nextState)
        {
            if (State!=null && !State.Exit(nextState))
                return false;
            if (!nextState.Enter(State))
                return false;
            State = nextState;
            return true;
        }

        public void Update()
        {
            State?.Update();
        }
    }
}
