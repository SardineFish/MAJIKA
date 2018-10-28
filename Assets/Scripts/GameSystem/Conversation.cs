using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;

[CreateAssetMenu(fileName ="Conversation",menuName ="Conversation")]
public class Conversation : ScriptableObject
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
