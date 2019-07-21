using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;


namespace MAJIKA.TextManager
{
    [CreateAssetMenu(fileName = "Conversation", menuName = "Conversation/Conversation")]
    public class ConversationAsset : ScriptableObject, IConversation
    {
        public List<string> Conversations;

        private IEnumerator<string> conversationEnumerator;

        IEnumerator<string> IEnumerable<string>.GetEnumerator()
        {
            return Conversations.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Conversations.GetEnumerator();
        }
    }

}

