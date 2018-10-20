using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SardineFish.Unity.FSM
{
    public interface IFSM<TState> where TState:IState<TState>
    {
        TState State { get; }
        bool ChangeState(TState nextState);
    }
}
