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
    public Conversation Conversation;
    public bool Ready = true;



    private IEnumerator<string> conversationEnumerator;

    void Update()
    {
        if (Conversation && conversationEnumerator == null)
        {
            conversationEnumerator = Conversation.Conversations.GetEnumerator();
            NextSentence();
        }
        if(Ready && conversationEnumerator!=null && InputManager.Instance.GetAction(InputManager.Instance.AcceptAction))
        {
            NextSentence();
        }
    }

    public void EndConversation()
    {
        conversationEnumerator = null;
        Conversation = null;
        LeftTalker = null;
        RightTalker = null;
        GameSystem.Instance.PlayerInControl.GetComponent<PlayerController>().playerFSM.ChangeState(PlayerState.Idle);
    }

    public void NextSentence()
    {
        if (conversationEnumerator.MoveNext())
            Wrapper.SetActive(true);
        else
        {
            Wrapper.SetActive(false);
            EndConversation();
            return;
        }
        var sentence = RenderSentence(conversationEnumerator.Current);
        StartCoroutine(TextCoroutine(sentence.Text));
        ImageRenderer.sprite = sentence.Talker.Image;
    }

    public IEnumerator TextCoroutine(string text)
    {
        Ready = false;
        for(var i = 0; i < text.Length; i++)
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
