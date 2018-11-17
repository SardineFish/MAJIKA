using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System;

public class ConversationUI : Singleton<ConversationUI>
{
    public GameObject Wrapper;
    public Text TextRenderer;
    public Image ImageRenderer;
    public Talker LeftTalker;
    public Talker RightTalker;
    public bool Ready = true;
    public IConversation Conversation;

    public event Action onComversationFinish;

    void Update()
    {
        if(Ready && Conversation!=null && InputManager.Instance.GetAction(InputManager.Instance.AcceptAction))
        {
            NextSentence();
        }
    }

    public void StartConversation(Talker left, Talker right, IConversation conversation)
    {
        this.LeftTalker = left;
        this.RightTalker = right;
        this.Conversation = conversation;
        this.Conversation.StartConversation();
        NextSentence();
    }

    public void EndConversation()
    {
        Conversation = null;
        LeftTalker = null;
        RightTalker = null;
        GameSystem.Instance.PlayerInControl.GetComponent<PlayerController>().playerFSM.ChangeState(PlayerState.Idle);
        onComversationFinish?.Invoke();
    }

    public void NextSentence()
    {
        var text = Conversation.Next();
        if(text == null)
        {
            Wrapper.SetActive(false);
            EndConversation();
            return;
        }
        else
            Wrapper.SetActive(true);
        var sentence = RenderSentence(text);
        StartCoroutine(TextCoroutine(sentence.Text));
        ImageRenderer.sprite = sentence.Talker.Image;
    }

    public IEnumerator TextCoroutine(string text)
    {
        Ready = false;
        for(var i = 0; i <= text.Length; i++)
        {
            TextRenderer.text = text.Substring(0, i);
            yield return new WaitForSeconds(0.1f);
        }
        Ready = true;
    }

    Sentence RenderSentence(string textTemplate)
    {
        var headerReg = new Regex(@"\$\{(.*?)\}:");
        var reg = new Regex(@"\$\{(.*?)\}");
        var talkerTemplate = headerReg.Match(textTemplate)?.Groups[1].Value;
        Talker talker = null;
        switch(talkerTemplate)
        {
            case "left":
                talker = LeftTalker;
                break;
            case "right":
                talker = RightTalker;
                break;
        }
        var text = reg.Replace(textTemplate, match => TemplateReplacer(match.Groups[1].Value));
        return new Sentence() { Talker = talker, Text = text };
    }

    string TemplateReplacer(string template)
    {
        var replacer = new Dictionary<string, Func<string>>();
        replacer["left"] = () => LeftTalker.Name;
        replacer["right"] = () => RightTalker.Name;
        return replacer[template]?.Invoke();
    }
}

class Sentence
{
    public Talker Talker;
    public string Text;
}
