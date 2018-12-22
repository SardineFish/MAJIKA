using UnityEngine;
using System.Collections;

namespace State
{
    [CreateAssetMenu(fileName = "Dead", menuName = "EntityState/Dead")]
    public class EntityDead : GameEntityState
    {
        public override bool OnExit(GameEntity entity, EntityState<GameEntity> nextState, EntityStateMachine<GameEntity> fsm)
        {
            return false;
        }
    }

}