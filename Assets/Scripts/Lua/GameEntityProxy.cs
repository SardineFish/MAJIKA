using MoonSharp.Interpreter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace LuaHost.Proxy
{
    class GameEntityProxy : ProxyBase<GameEntity>
    {

        [MoonSharpHidden]
        public GameEntityProxy(GameEntity entity) : base(entity)
        {
            entity.OnUpdate += EntityUpdate;
        }
        private void EntityUpdate()
        {
            OnUpdate?.Invoke(target);
            if (target is LifeEntity && (target as LifeEntity).HP <= 0)
            {
                OnDead?.Invoke(target);
            }
        }
        public Vector2 Position
        {
            get
            {
                return target.transform.position.ToVector2();
            }
            set
            {
                target.transform.position = target.transform.position.Set(x: value.x, y: value.y);
            }
        }
        public void Skill(int idx)
        {
            target.GetComponent<EntityController>()?.Skill(idx);
        }
        public void Move(Vector2 movement)
        {
            target.GetComponent<EntityController>()?.Move(movement);
        }
        public void Jump()
        {
            target.GetComponent<EntityController>()?.Jump();
        }
        public void Climb(float speed)
        {
            target.GetComponent<EntityController>()?.Climb(speed);
        }
        public void StartCoroutine(Closure closure)
        {

        }
        public event Action<GameEntity> OnDead;
        public event Action<GameEntity> OnUpdate;
    }
}
