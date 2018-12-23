using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System;

public class ConversationUI : Singleton<ConversationUI>
{
    public float WPS = 10;
    public GameObject Wrapper;
    public Text TextRenderer;
    public Image ImageRenderer;
    public Talker[] Talkers;
    public IConversation Conversation;
    public bool Talking = false;

    public event Action onComversationFinish;

    void Update()
    {
    }

    public IEnumerator StartConversation(IConversation conversation, Talker[] talkers, bool lockPlayer = false)
    {
        Guid lockID;
        if (lockPlayer)
            GameSystem.Instance.PlayerInControl.GetComponent<EntityController>().Lock();

        Talkers = talkers;
        Conversation = conversation;
        Talking = true;
        Wrapper.SetActive(true);

        foreach (var text in conversation)
        {
            yield return ShowSentence(text);
        }
        Talkers = null;
        Conversation = null;
        Wrapper.SetActive(false);
        GameSystem.Instance.PlayerInControl.GetComponent<EntityController>().UnLock(lockID);
    }

    public void EndConversation()
    {
        Conversation = null;
        GameSystem.Instance.PlayerInControl.GetComponent<PlayerController>().playerFSM.ChangeState(PlayerState.Idle);
        onComversationFinish?.Invoke();
    }

    public IEnumerator ShowSentence(string text)
    {
        var sentence = RenderSentence(text);
        var secondsPerWord = 1 / WPS;
        for(var i = 0; i <= sentence.Text.Length; i++)
        {
            if (InputManager.Instance.GetAction(InputManager.Instance.AcceptAction))
                i = sentence.Text.Length;
            TextRenderer.text = text.Substring(0, i);
            yield return new WaitForSeconds(secondsPerWord);
        }
        yield return InputManager.Instance.WaitForAction(InputManager.Instance.AcceptAction);
    }
    Sentence RenderSentence(string textTemplate)
    {
        var headerReg = new Regex(@"\$\{(.*?)\}:");
        var reg = new Regex(@"\$\{(.*?)\}");
        var talkerTemplate = headerReg.Match(textTemplate)?.Groups[1].Value;
        Talker talker = null;
        switch(talkerTemplate)
        {
            case "player":
                talker = FindObjectOfType<Player>().GetComponent<Talkable>().Talker;
                break;
            default:
                try
                {
                    talker = Talkers[Convert.ToInt32(talkerTemplate)];
                }
                catch
                {
                    talker = null;
                }
                break;
        }
        var text = reg.Replace(textTemplate, match => TemplateReplacer(match.Groups[1].Value));
        return new Sentence() { Talker = talker, Text = text };
    }

    string TemplateReplacer(string template)
    {
        var replacer = new Dictionary<string, Func<string>>();
        if (template == "player")
            return FindObjectOfType<Player>().GetComponent<Talkable>().Talker.Name;
        try
        {
            return Talkers[Convert.ToInt32(template)].Name;
        }
        catch
        {
            return $"{{{template}}}";
        }
    }
}

class Sentence
{
    public Talker Talker;
    public string Text;
}
