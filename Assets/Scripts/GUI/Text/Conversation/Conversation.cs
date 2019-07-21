using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;

namespace MAJIKA.TextManager
{
    public class Conversation : IConversation
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

}