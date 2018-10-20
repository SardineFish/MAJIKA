using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SardineFish.Unity.FSM
{
    public interface IState<T> where T:IState<T>
    {
        bool OnEnter(T previousState);
        bool OnExit(T nextstate);
        void OnUpdate();
    }
}
