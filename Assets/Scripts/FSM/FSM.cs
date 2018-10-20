using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SardineFish.Unity.FSM
{
    public class FSM:IFSM<State>
    {
        public State State { get; private set; }
        public FSM()
        {
            State = null;
        }
        public FSM(State initialState) : this()
        {
            State = initialState;
        }

        public bool ChangeState(State nextState)
        {
            if (State!=null && !State.OnExit(nextState))
                return false;
            if (!nextState.OnEnter(State))
                return false;
            State = nextState;
            return true;
        }

        public void Update()
        {
            State?.OnUpdate();
        }
    }
}
