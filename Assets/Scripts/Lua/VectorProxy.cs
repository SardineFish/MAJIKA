using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using MoonSharp.Interpreter;

namespace LuaHost.Proxy
{
    [MoonSharpUserData]
    class Vector2Wrapper
    {
        public float x;
        public float y;
        public Vector2Wrapper(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
