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
        public UnityEngine.Coroutine tips(string tips, float time = 3)
        {
            return host.StartCoroutine(Tips.Instance.ShowTipsWait(tips, time));
        }
        public void Control(GameEntity entity)
        {
            GameObject.Destroy(GameSystem.Instance.PlayerInControl.GetComponent<EntityInputPlugin>());
            entity.gameObject.AddComponent<EntityInputPlugin>();
            GameSystem.Instance.PlayerInControl = entity;
        }
    }
}
