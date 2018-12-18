using UnityEngine;
using System.Collections;

public class EntityStateController : EntityStateMachine<GameEntity>
{
    public GameEntityState InitialState;
    private void Awake()
    {
        ChangeState(InitialState);
    }
}
