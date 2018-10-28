using UnityEngine;
using System.Collections;

public class EntityController : EntityStateMachine<GameEntity>
{
    public GameEntityState InitialState;
    private void Awake()
    {
        ChangeState(InitialState);
    }
}
