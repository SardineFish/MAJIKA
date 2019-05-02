using UnityEngine;
using System.Collections;

namespace State
{
    [CreateAssetMenu(fileName = "Stun", menuName = "EntityState/Stun")]
    public class EntityStun : GameEntityState
    {
        public EntityIdle IdleState;
        
    }

}