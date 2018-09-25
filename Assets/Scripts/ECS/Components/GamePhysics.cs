using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Entities;
using UnityEngine;

namespace Assets.Scripts.ECS
{
    [Serializable]
    public struct GamePhysics : IComponentData
    {
        public Vector2 velocity;
        public Vector2 extraVelocity;
    }
}
