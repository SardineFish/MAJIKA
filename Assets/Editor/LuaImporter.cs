using UnityEngine;
using UnityEditor.Experimental.AssetImporters;
using System.IO;

namespace Assets.Editor
{
    [ScriptedImporter(1, "lua")]
    class LuaImporter : ScriptedImporter
    {
        public override void OnImportAsset(AssetImportContext ctx)
        {
            var asset = new TextAsset(File.ReadAllText(ctx.assetPath));
            ctx.AddObjectToAsset("Text", asset);
            ctx.SetMainObject(asset);
        }
    }
}
