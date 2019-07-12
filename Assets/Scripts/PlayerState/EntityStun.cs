using UnityEngine;
using System.Collections;

namespace State
{
    [CreateAssetMenu(fileName = "Stun", menuName = "EntityState/Stun")]
    public class EntityStun : AnimatedState
    {
        public EntityIdle IdleState;
        public override void OnUpdate(GameEntity entity, EntityStateMachine fsm)
        {
            if (entity.GetComponent<EntityEffector>().GetEffect<Stun>() == null)
                fsm.ChangeState(IdleState);
        }
    }

}