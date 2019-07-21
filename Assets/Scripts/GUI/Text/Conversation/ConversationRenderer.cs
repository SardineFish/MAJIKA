using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MAJIKA.TextManager
{
    public class ConversationRenderer : IConversation
    {
        string[] conversation;

        public ConversationRenderer(string[] conversation)
        {
            this.conversation = conversation;
        }

        public IEnumerator<string> GetEnumerator()
        {
            return RenderSentences(conversation);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return RenderSentences(conversation);
        }

        public static IEnumerator<string> RenderSentences(string[] conversation)
        {
            var reg = new Regex(@"^\${conv:(\S+)}$", RegexOptions.ECMAScript);
            foreach (var sentence in conversation)
            {
                var match = reg.Match(sentence);
                if (match.Success)
                {
                    var subConversation = ConversationManager.GetConversation(match.Groups[1].Value);
                    if (subConversation is null)
                        yield return "<undefined>";
                    else
                    {
                        foreach (var subSentence in subConversation)
                        {
                            yield return subSentence;
                        }
                    }
                }
                else
                    yield return sentence;
            }
        }
    }
}
