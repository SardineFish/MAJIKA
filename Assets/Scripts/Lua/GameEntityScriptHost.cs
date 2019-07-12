using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using LuaHost;

[RequireComponent(typeof(GameEntity))]
public class GameEntityScriptHost : LuaScriptHost, IEntityLifeCycle
{
    public override void InitRuntime()
    {
        base.InitRuntime();
        LuaScript.Globals["entity"] = GetComponent<GameEntity>();
    }

    public void OnActive()
    {
        LuaScript.Globals.Get("active").Function?.Call();
    }

    public void OnInactive()
    {
        LuaScript.Globals.Get("inactive").Function?.Call();
    }
}