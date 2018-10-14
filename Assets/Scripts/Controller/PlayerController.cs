using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MonsterLove.StateMachine;
using SardineFish.Unity.FSM;

[RequireComponent(typeof(Player), typeof(MovableEntity))]
public class PlayerController : FSMBehaviour<Player,PlayerState>
{
    public RuntimeAnimatorController Idle;
    public RuntimeAnimatorController Walk;
    public RuntimeAnimatorController Jump;
    private void Awake()
    {
        ChangeState(new PlayerOnGround(Entity));
    }
}
