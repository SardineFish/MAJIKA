using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using MoonSharp.Interpreter;

namespace LuaHost
{
    [MoonSharpUserData]
    public class GameHost:HostBase
    {
        [MoonSharpHidden]
        public GameHost(LuaScriptHost host):base(host)
        {
        }
        public UnityEngine.Coroutine Conversation(List<string> conversation, GameEntity[] talkers, bool lockPlayer = true)
        {
            return host.StartCoroutine(ConversationUI.Instance.StartConversation(new Conversation(conversation), talkers.Select(entity => entity.GetComponent<Talkable>().Talker).ToArray()));
        }
        /*
        public Promise ConversationAsync(GameEntity left, GameEntity right, List<string> conversation)
        {
            return new Promise((resolve) =>
            {
                Action callback = null;
                callback = () =>
                {
                    ConversationUI.Instance.onComversationFinish -= callback;
                    resolve();
                };
                ConversationUI.Instance.StartConversation(left.GetComponent<Talkable>().Talker, right.GetComponent<Talkable>().Talker, new Conversation(conversation));
                ConversationUI.Instance.onComversationFinish += callback;
            }, host);
        }*/
    }
}
