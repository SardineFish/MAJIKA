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
            return host.StartCoroutine(ConversationUI.Instance.StartConversation(new Conversation(conversation), talkers.Select(entity => entity.GetComponent<Talkable>().Talker).ToArray(),lockPlayer));
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
            GameGUIManager.Instance.GetComponent<SkillUIManager>().DisplayEntity = entity;
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

        public void PlayAudio(AudioClip clip, float volumn = 1, float time = 0, bool loop = false)
        {
            Level.Instance.GetComponent<AudioController>().StartCoroutine(Level.Instance.GetComponent<AudioController>().Enter(clip, volumn, time, loop));
            Level.Instance.GetComponent<AudioSource>().clip = clip;
            Level.Instance.GetComponent<AudioSource>().volume = volumn;
            Level.Instance.GetComponent<AudioSource>().Play();
        }

        public void ExitAudio(float time = 1)
        {
            Level.Instance.GetComponent<AudioController>().StartCoroutine(Level.Instance.GetComponent<AudioController>().Exit(time));
        }
    }
}
