using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using MoonSharp.Interpreter;
using MAJIKA.TextManager;

namespace MAJIKA.Lua
{
    [MoonSharpUserData]
    public class GameHost:HostBase
    {
        [MoonSharpHidden]
        public GameHost(LuaScriptHost host):base(host)
        {
        }
        public UnityEngine.Coroutine Conversation(string[] conversation, GameEntity[] talkers, bool lockPlayer = true, bool autoHide = true)
        {
            return host.StartCoroutine(ConversationUI.Instance.StartConversationAsync(
                new ConversationRenderer(conversation), 
                talkers.Select(entity => entity.GetComponent<Talkable>().Talker).ToArray(),
                lockPlayer,
                autoHide));
        }
        public UnityEngine.Coroutine Conversation(string conversation, GameEntity[] talkers, bool lockPlayer = true, bool autoHide = true)
        {
            return host.StartCoroutine(ConversationUI.Instance.StartConversationAsync(
                new ConversationRenderer(new string[] { conversation }), 
                talkers.Select(entity => entity.GetComponent<Talkable>().Talker).ToArray(), 
                lockPlayer,
                autoHide));
        }
        public UnityEngine.Coroutine Choose(string[] options, Closure callback)
        {
            return host.StartCoroutine(MAJIKA.GUI.SelectMenu.Show(options,(i)=> callback.Call(i)));
        }
        public UnityEngine.Coroutine tips(string tips, float time = 3)
        {
            return host.StartCoroutine(Tips.Instance.ShowTipsWait(tips, time));
        }
        public void Control(GameEntity entity)
        {
            GameSystem.Instance.Control(entity);
        }
        public void SetTarget(GameEntity entity, string name)
        {
            GameGUIManager.Instance.GetComponent<MAJIKA.GUI.CoveredUI>().ShowAsync();
            GameGUIManager.Instance.TargetUI.SetTarget(name, entity);
        }
        public void Target(GameEntity entity, string name)
            => SetTarget(entity, name);
        public void Over()
        {
            Level.Instance.GetComponent<EventBus>().Dispatch(Level.EventFailed);
        }
        public void Pass()
        {
            Level.Instance.GetComponent<EventBus>().Dispatch(Level.EventPass);
        }
        public void Ready()
        {
            Level.Instance.Ready();
        }
        public void Pass(string nextLevel)
        {
            Level.Instance.NextScene = nextLevel;
            Level.Instance.GetComponent<EventBus>().Dispatch(Level.EventPass);
        }
        public void LoadLevel(string level)
        {
            LevelLoader.Instance.LoadLevelDetach(level);
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

        public void LoadScene(string path)
        {
            LevelLoader.Instance.LoadLevelDetach(path);
        }

        public PlayerProfile Profile => Saves.Instance.Profile;

        public void Save() => Saves.Instance.Save();
    }

    
}
