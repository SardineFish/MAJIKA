using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SardineFish.Unity.FSM;
using UnityEngine;

[Serializable]
public class EntityStateMachine : EntityBehaviour, IFSM<EntityState>
{
    [SerializeField]
    private EntityState state;
    public EntityState State => this.state;
    Coroutine currentStateCoroutine;
    
    [SerializeField]
    private string currentState;


    public virtual bool ChangeState(EntityState nextState)
    {
        if (nextState == null)
            return false;
        if (State != null && !State.OnExit(Entity, nextState, this))
            return false;
        if (!nextState.OnEnter(Entity, State, this))
            return false;
        if (currentStateCoroutine != null)
            Entity.StopCoroutine(currentStateCoroutine);
        state = nextState;
        currentStateCoroutine = Entity.StartCoroutine(State.Begin(Entity, this));
        return true;
    }

    protected virtual void Update()
    {
        if (State)
        {
            currentState = State.name;
            State.OnUpdate(Entity, this);
        }
    }
}
