using UnityEngine;
using System.Collections;

namespace State
{
    [CreateAssetMenu(fileName = "Birth", menuName = "EntityState/Birth")]
    public class EntityBirth : GameEntityState
    {
        public EntityIdle IdleState;
        public override IEnumerator Begin(GameEntity entity, EntityStateMachine<GameEntity> fsm)
        {
            yield return entity.GetComponent<AnimationController>().WaitAnimation();
        }
    }
}
