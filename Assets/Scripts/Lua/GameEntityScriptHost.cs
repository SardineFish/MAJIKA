using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace LuaHost
{
    [RequireComponent(typeof(GameEntity))]
    public class GameEntityScriptHost : LuaScriptHost
    {
        public override void InitRuntime()
        {
            base.InitRuntime();
            LuaScript.Globals["entity"] = GetComponent<GameEntity>();
        }
    }
}
