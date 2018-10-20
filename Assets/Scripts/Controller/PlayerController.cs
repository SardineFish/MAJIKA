using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MonsterLove.StateMachine;
using SardineFish.Unity.FSM;

[RequireComponent(typeof(Player), typeof(MovableEntity))]
public class PlayerController : EntityStateMachine<Player>
{
    public PlayerState InitialState;
    private void Awake()
    {
        ChangeState(InitialState);
    }
}
