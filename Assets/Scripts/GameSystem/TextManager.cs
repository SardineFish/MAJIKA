using UnityEngine;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using MoonSharp.Interpreter;
using System.Text.RegularExpressions;
using UnityEngine.UI;
using MAJIKA.TextManager;


[CreateAssetMenu(fileName = "TextManager", menuName = "GameSystem/TextManager")]
public class TextManager : SingletonAsset<TextManager>
{
    public List<TextDefinitionAsset> TextDefinitions = new List<TextDefinitionAsset>();


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
        TextDefinitions.ForEach(textDef => textDef.Reload());
    }

    public static string GetTextByReference(string id, ITextDefinition addition = null)
    {
        if (addition != null && addition.Has(id))
            return RenderText(addition[id]);
        for (var i = 0; i < Asset.TextDefinitions.Count; i++)
        {
            if (Asset.TextDefinitions[i].Has(id))
                return RenderText(Asset.TextDefinitions[i][id]);
        }
        return "<undefined>";
    }

    public static string RenderText(string text, ITextDefinition addition = null)
    {
        if (text == null)
            return "<null>";
        else if (text == "")
            return text;
        var reg = new Regex(@"\${(\w+)}", RegexOptions.ECMAScript);
        return reg.Replace(text, (match) =>
            GetTextByReference(match.Groups[1].Value, addition));

    }

    public static void RenderAllUI()
    {
        Resources.FindObjectsOfTypeAll<Text>()
            .Where(text => text)
            .ForEach(text => text.text = RenderText(text.text));
    }
}