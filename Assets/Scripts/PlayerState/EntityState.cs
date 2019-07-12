using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SardineFish.Unity.FSM;
using UnityEngine;

public class EntityState : StateAsset, IState<EntityState>
{
    public bool OnEnter(EntityState previousState)
    {
        return true;
    }

    public bool OnExit(EntityState nextstate)
    {
        return true;
    }

    public void OnUpdate()
    {

    }

    public virtual IEnumerator Begin(GameEntity entity, EntityStateMachine fsm)
    {
        yield break;

    }

    public virtual bool OnEnter(GameEntity entity, EntityState previousState, EntityStateMachine fsm)
    {
        return true;
    }

    public virtual bool OnExit(GameEntity entity, EntityState nextState, EntityStateMachine fsm)
    {
        return true;
    }

    public virtual void OnUpdate(GameEntity entity, EntityStateMachine fsm)
    {
        
    }
}