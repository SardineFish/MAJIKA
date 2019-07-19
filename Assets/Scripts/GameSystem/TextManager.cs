using UnityEngine;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using MoonSharp.Interpreter;
using System.Text.RegularExpressions;

[CreateAssetMenu(fileName ="TextManager", menuName ="GameSystem/TextManager")]
public class TextManager : SingletonAsset<TextManager>
{
    [SerializeField]
    public List<TextAsset> TextDefinitionCode = new List<TextAsset>();
    Script ScriptRuntime;
    Dictionary<string, string> TextDefinitions = new Dictionary<string, string>();

    public int DefinitionCount => TextDefinitions.Count;

    private void OnEnable()
    {
        Reload();
    }
    void Awake()
    {
        Reload();
    }

    public void Reload()
    {
        if (ScriptRuntime is null)
            ScriptRuntime = new Script();
        else
            ScriptRuntime.Globals.Clear();
        TextDefinitionCode.ForEach(code => ScriptRuntime.DoString(code.text));
        ScriptRuntime.Globals.Keys
            .Select(key => key.String)
            .Where(key => key != null && key != "")
            .Where(key=>ScriptRuntime.Globals.Get(key).ReadOnly)
            .ForEach(key => TextDefinitions[key] = ScriptRuntime.Globals.Get(key).String);
        Debug.Log($"Loaded {DefinitionCount} text definitions.");
    }

    public static string RenderText(string text, Dictionary<string, string> additionTemplate = null)
    {
        var reg = new Regex(@"\${(\w+)}", RegexOptions.ECMAScript);
        return reg.Replace(text, (match) =>
        {
            var reference = match.Groups[1].Value;
            if (additionTemplate != null && additionTemplate.ContainsKey(reference))
                return RenderText(additionTemplate[reference], additionTemplate);
            else if (Asset.TextDefinitions.ContainsKey(reference))
                return RenderText(Asset.TextDefinitions[reference]);
            else
                return "";
        });
        
    }
}
