using UnityEngine;
using System.Collections;
using System;
using MoonSharp.Interpreter;

namespace LuaHost
{
    public class ResourceLoader : LuaScriptHost
    {

        public override void InitRuntime()
        {
            LuaScript = new Script();
            UserData.RegisterAssembly();
            UserData.RegisterType<Vector3>();
            UserData.RegisterType<Vector2>();
            LuaScriptHost.EnableConsole(LuaScript);
            ResourcesHost.AddHost(LuaScript);
            UserData.RegisterProxyType<InventoryHost.ItemProxy, Inventory.Item>(item => new InventoryHost.ItemProxy(item, this));
            UserData.RegisterProxyType<InventoryHost.RecipeProxy, Inventory.Recipe>(obj => new InventoryHost.RecipeProxy(obj, this));
            LuaScript.Globals["RecipeType"] = typeof(InventoryHost.RecipeProxy);
        }
    }

}