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
        public bool Skill(int idx)
        {
            if (!target.GetComponent<SkillController>())
                return false;
            return target.GetComponent<SkillController>().Activate(idx);
        }
        public bool Move(Vector2 movement)
        {
            return target.GetComponent<MovableEntity>().Move(movement);
        }
        public bool Jump()
        {
            return target.GetComponent<MovableEntity>().Jump();
        }
        public bool Climb(float speed)
        {
            return target.GetComponent<MovableEntity>().Climb(speed);
        }
        public void StartCoroutine(Closure closure)
        {

        }
        public event Action<GameEntity> OnDead;
        public event Action<GameEntity> OnUpdate;
    }
}
