using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System;

namespace SardineFish.Unity.FSM
{
    public abstract class FSMBehaviour<TEntity, TState> : EntityBehaviour<TEntity> where TState : State where TEntity : GameEntity
    {
        public FSM<TState> fsm = new FSM<TState>();
        public TState State => fsm.State;
        public bool ChangeState(TState nextState) => fsm.ChangeState(nextState);
        protected virtual void Update()
        {
            State?.Update();
        }
    }

}