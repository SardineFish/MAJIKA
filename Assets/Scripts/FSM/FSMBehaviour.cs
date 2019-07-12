using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System;

namespace SardineFish.Unity.FSM
{
    public abstract class FSMBehaviour<TEntity> : EntityBehaviour
        where TEntity : GameEntity
    {
        public FSM fsm = new FSM();
        public State State => fsm.State;
        public bool ChangeState(State nextState) => fsm.ChangeState(nextState);
        protected virtual void Update()
        {
            State?.OnUpdate();
        }
    }

}