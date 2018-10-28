using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MonsterLove.StateMachine;
using SardineFish.Unity.FSM;

public enum PlayerState
{
    Idle,
    Combat,
    Interact
}
[RequireComponent(typeof(Player), typeof(MovableEntity), typeof(EventBus))]
public class PlayerController : EntityStateMachine<Player>
{
    public SimpleFSM<PlayerState> playerFSM;
    public PlayerControllerState InitialState;
    [SerializeField]
    private string playerState;
    private void Awake()
    {
        playerFSM = new SimpleFSM<PlayerState>(this, PlayerState.Idle);
        ChangeState(InitialState);
    }

    [StateUpdate(PlayerState.Idle)]
    void IdleUpdate()
    {
        base.Update();
    }

    [StateUpdate(PlayerState.Combat)]
    void CombatUpdate()
    {
        base.Update();
    }

    [StateUpdate(PlayerState.Interact)]
    void InteractUpdate()
    {

    }

    protected override void Update()
    {
        playerState = playerFSM.State.ToString();
        playerFSM.Update();
    }
}
