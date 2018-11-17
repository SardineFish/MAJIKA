using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using MoonSharp.Interpreter;

namespace LuaHost
{
    class GameObjectProxy
    {
        GameObject gameObject;

        [MoonSharpHidden]
        public GameObjectProxy(GameObject gameObject)
        {
            this.gameObject = gameObject;
        }
    }
}
