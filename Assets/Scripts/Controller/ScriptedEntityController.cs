using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LuaHost;

namespace Assets.Scripts.Controller
{
    public class ScriptedEntityController : LuaScriptHost
    {
        public override void InitRuntime()
        {
            base.InitRuntime();
            LuaScript.Globals["entity"] = GetComponent<GameEntity>();
            
        }
        protected override void Start()
        {
            base.Start();
            LuaScript.Globals.Get("start").Function?.Call();
        }
        private void Update()
        {
            LuaScript.Globals.Get("update").Function?.Call();

        }
    }
}
