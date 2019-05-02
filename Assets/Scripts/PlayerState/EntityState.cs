using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SardineFish.Unity.FSM;
using UnityEngine;

public class EntityState<TEntity> : StateAsset, IState<EntityState<TEntity>> where TEntity: GameEntity
{
    public bool OnEnter(EntityState<TEntity> previousState)
    {
        return true;
    }

    public bool OnExit(EntityState<TEntity> nextstate)
    {
        return true;
    }

    public void OnUpdate()
    {

    }

    public virtual IEnumerator Begin(TEntity entity, EntityStateMachine<TEntity> fsm)
    {
        yield break;

    }

    public virtual bool OnEnter(TEntity entity, EntityState<TEntity> previousState, EntityStateMachine<TEntity> fsm)
    {
        return true;
    }

    public virtual bool OnExit(TEntity entity, EntityState<TEntity> nextState, EntityStateMachine<TEntity> fsm)
    {
        return true;
    }

    public virtual void OnUpdate(TEntity entity, EntityStateMachine<TEntity> fsm)
    {
        
    }
}