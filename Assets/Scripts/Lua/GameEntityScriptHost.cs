using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using MAJIKA.Lua;

[RequireComponent(typeof(GameEntity))]
public class GameEntityScriptHost : LuaScriptHost, IEntityLifeCycle
{
    GameEntity entity;
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

    protected override void Awake()
    {
        base.Awake();
        entity = GetComponent<GameEntity>();
    }

    protected override void Start()
    {
        LuaScript.Globals.Get("start").Function?.Call();
    }

    protected override void Update()
    {
        if (entity.active)
            LuaScript.Globals.Get("update").Function?.Call();
    }
}