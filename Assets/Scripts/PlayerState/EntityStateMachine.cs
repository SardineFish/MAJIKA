using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SardineFish.Unity.FSM;
using UnityEngine;

[Serializable]
public class EntityStateMachine<TEntity> : EntityBehaviour<TEntity>, IFSM<EntityState<TEntity>> where TEntity:GameEntity
{
    [SerializeField]
    private EntityState<TEntity> state;
    public EntityState<TEntity> State => this.state;

    
    [SerializeField]
    private string currentState;


    public bool ChangeState(EntityState<TEntity> nextState)
    {
        if (nextState == null)
            return false;
        if (State != null && !State.OnExit(Entity, nextState, this))
            return false;
        if (!nextState.OnEnter(Entity, State, this))
            return false;
        state = nextState;
        return true;
    }

    void Update()
    {
        if (State)
        {
            currentState = State.name;
            State.OnUpdate(Entity, this);
        }
    }
}
