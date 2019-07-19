using UnityEngine;
using UnityEditor.Experimental.AssetImporters;
using System.IO;
using MAJIKA.Lua;

namespace Assets.Editor
{
    [ScriptedImporter(3, "lua")]
    class LuaImporter : ScriptedImporter
    {
        public override void OnImportAsset(AssetImportContext ctx)
        {
            var asset = LuaScript.CreateInstance<LuaScript>();
            asset.text = File.ReadAllText(ctx.assetPath);
            ctx.AddObjectToAsset("Text", asset);
            ctx.SetMainObject(asset);
        }
    }
}
