using UnityEngine;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using MoonSharp.Interpreter;
using MAJIKA.Lua;

namespace MAJIKA.TextManager
{
    [CreateAssetMenu(fileName ="ScriptedTextDefinition", menuName ="TextDefinition/Scripted")]
    public class ScriptedTextDefinition : TextDefinitionAsset
    {
        [SerializeField]
        public List<LuaScript> TextDefinitionCode = new List<LuaScript>();
        Script ScriptRuntime;
        Dictionary<string, string> TextDefinitions = new Dictionary<string, string>();
        public int DefinitionCount => TextDefinitions.Count;

        public override string this[string id] => TextDefinitions[id];

        public override void Reload()
        {
            if (ScriptRuntime is null)
                ScriptRuntime = new Script();
            else
                ScriptRuntime.Globals.Clear();
            TextDefinitionCode.ForEach(code => ScriptRuntime.DoString(code.text));
            ScriptRuntime.Globals.Keys
                .Select(key => key.String)
                .Where(key => key != null && key != "")
                .Where(key => ScriptRuntime.Globals.Get(key).ReadOnly)
                .ForEach(key => TextDefinitions[key] = ScriptRuntime.Globals.Get(key).String);
            Debug.Log($"Loaded {DefinitionCount} text definitions.");
        }

        public override bool Has(string id) => TextDefinitions.ContainsKey(id);
    }

}