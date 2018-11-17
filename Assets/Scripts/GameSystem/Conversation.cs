using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;

public interface IConversation
{
    void StartConversation();

    string Next();
}
[CreateAssetMenu(fileName ="Conversation",menuName ="Conversation/Conversation")]
public class ConversationAsset : ScriptableObject,IConversation
{
    public List<string> Conversations;

    private IEnumerator<string> conversationEnumerator;

    public void StartConversation()
    {
        conversationEnumerator = Conversations.GetEnumerator();
    }

    public string Next()
    {
        conversationEnumerator.MoveNext();
        return conversationEnumerator.Current;
    }
}
public class Conversation: IConversation
{
    public List<string> Conversations;

    private IEnumerator<string> conversationEnumerator;

    public Conversation(List<string> conversations)
    {
        this.Conversations = conversations;
    }

    public void StartConversation()
    {
        conversationEnumerator = Conversations.GetEnumerator();
    }

    public string Next()
    {
        if (conversationEnumerator.MoveNext())
            return conversationEnumerator.Current;
        return null;
    }

}
