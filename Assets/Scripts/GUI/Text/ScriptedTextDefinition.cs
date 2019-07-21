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
        public List<TextAsset> TextDefinitionCode = new List<TextAsset>();
        Dictionary<string, string> TextDefinitions = new Dictionary<string, string>();
        public int DefinitionCount => TextDefinitions.Count;

        public override string this[string id] => TextDefinitions[id];

        public override void Reload()
        {
            TextDefinitions.Clear();
            var deserializer = new YamlDotNet.Serialization.Deserializer();
            TextDefinitionCode
                .Where(asset => asset)
                .Select(asset => deserializer.Deserialize<Dictionary<string, string>>(asset.text))
                .ForEach(dict => dict.ForEach(pair => TextDefinitions[pair.Key] = pair.Value));
                
            Debug.Log($"Loaded {DefinitionCount} text definitions.");
        }

        public override bool Has(string id) => TextDefinitions.ContainsKey(id);
    }

}