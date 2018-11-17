using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEditor;
using UnityEditor.Experimental.AssetImporters;
using System.IO;

namespace Assets.Editor
{
    [ScriptedImporter(1, "lua")]
    class LuaImporter : ScriptedImporter
    {
        public override void OnImportAsset(AssetImportContext ctx)
        {
            var asset = new TextAsset();
            ctx.AddObjectToAsset("Text", asset);
            ctx.SetMainObject(asset);
            asset.name = Path.GetFileName(ctx.assetPath);
        }
    }
}
