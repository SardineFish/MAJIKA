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
            if (GameSystem.Instance.PlayerInControl)
                GameObject.Destroy(GameSystem.Instance.PlayerInControl.GetComponent<EntityInputPlugin>());
            if (entity)
                entity.gameObject.AddComponent<EntityInputPlugin>();
            GameSystem.Instance.PlayerInControl = entity;
            GameGUIManager.Instance.PlayerHP.DisplayEntity = entity as LifeEntity;
        }
        public void SetTarget(GameEntity entity, string name)
        {
            GameGUIManager.Instance.TargetUI.SetTarget(name, entity);
        }
        public void Over()
        {
            Debug.Log("Game Over");
            Level.Instance.GetComponent<EventBus>().Dispatch(Level.EventFailed);
        }
        public void Pass()
        {
            Debug.Log("Level Pass");
            Level.Instance.GetComponent<EventBus>().Dispatch(Level.EventPass);
        }
    }
}
