using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;

public interface IConversation : IEnumerable<string>
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

    void IConversation.StartConversation()
    {
        throw new NotImplementedException();
    }

    string IConversation.Next()
    {
        throw new NotImplementedException();
    }

    IEnumerator<string> IEnumerable<string>.GetEnumerator()
    {
        return Conversations.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return Conversations.GetEnumerator();
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

    public IEnumerator<string> GetEnumerator()
        => Conversations.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator()
        => Conversations.GetEnumerator();
}
