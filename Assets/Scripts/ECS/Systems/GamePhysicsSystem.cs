using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Unity.Entities;
using Unity.Jobs;

namespace Assets.Scripts.ECS.Systems
{
    public class GamePhysicsSystem : JobComponentSystem 
    {
        struct GamePhysicsJob : IJobProcessComponentData<GamePhysics>
        {
            public float dt;
            public Vector2 gravity;
            public void Execute(ref GamePhysics data)
            {
                data.velocity += gravity * dt;
            }
        }

        protected override JobHandle OnUpdate(JobHandle inputDeps)
        {
            var job = new GamePhysicsJob() { dt = Time.deltaTime, gravity = Vector2.down * PhysicsSystem.Instance.Gravity };
            return job.Schedule(this, inputDeps);
        }
    }
}
