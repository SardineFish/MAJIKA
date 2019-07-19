using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAJIKA.Lua;

namespace Assets.Scripts.Controller
{
    public class ScriptedEntityController : LuaScriptHost
    {
        public override void InitRuntime()
        {
            base.InitRuntime();
            LuaScript.Globals["entity"] = GetComponent<GameEntity>();
            
        }
    }
}
