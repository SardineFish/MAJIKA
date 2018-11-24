using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using MoonSharp.Interpreter;

namespace LuaHost.Proxy
{
    class ProxyBase<T> where T:class
    {
        protected T target;
        public ProxyBase(T target)
        {
            this.target = target;
        }
    }
    class GameObjectProxy:ProxyBase<GameObject>
    {

        [MoonSharpHidden]
        public GameObjectProxy(GameObject gameObject):base(gameObject)
        {
        }
        public string name => target.name;
    }

    class GameEntityProxy:ProxyBase<GameEntity>
    {

        [MoonSharpHidden]
        public GameEntityProxy(GameEntity entity):base(entity)
        {
            entity.OnUpdate += EntityUpdate;
        }
        private void EntityUpdate()
        {
            OnUpdate?.Invoke(target);
            if(target is LifeEntity && (target as LifeEntity).HP <= 0)
            {
                OnDead?.Invoke(target);
            }
        }
        public event Action<GameEntity> OnDead;
        public event Action<GameEntity> OnUpdate;
    }

    class Vector2Proxy
    {
        Vector2 vector;

        [MoonSharpHidden]
        public Vector2Proxy(Vector2 v)
        {
            this.vector = v;
        }

        public float x
        {
            get { return vector.x; }
            set { vector.x = value; }
        }
        public float y
        {
            get { return vector.y; }
            set { vector.y = value; }
        }
        public float magnitude => vector.magnitude;
        public Vector2 normalized => vector.normalized;
    }
}
