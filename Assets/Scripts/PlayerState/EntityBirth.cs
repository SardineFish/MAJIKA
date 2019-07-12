using UnityEngine;
using System.Collections;

namespace State
{
    [CreateAssetMenu(fileName = "Birth", menuName = "EntityState/Birth")]
    public class EntityBirth : AnimatedState
    {
        public EntityIdle IdleState;
        public override IEnumerator Begin(GameEntity entity, EntityStateMachine fsm)
        {
            yield return entity.GetComponent<AnimationController>().WaitAnimation();
            fsm.ChangeState(IdleState);
        }
    }
}
