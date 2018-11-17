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
        T target;
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
    }

    class GameEntityProxy:ProxyBase<GameEntity>
    {

        [MoonSharpHidden]
        public GameEntityProxy(GameEntity entity):base(entity)
        {
        }
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
