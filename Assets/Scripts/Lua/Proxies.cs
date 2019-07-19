using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using MoonSharp.Interpreter;

namespace MAJIKA.Lua.Proxy
{
    public class ProxyBase<T> where T:class
    {
        [MoonSharpHidden]
        public T target;
        protected LuaScriptHost host;
        public ProxyBase(T target):this(target,null)
        {
        }
        public ProxyBase(T target,LuaScriptHost host)
        {
            this.target = target;
            this.host = host;
        }
    }
    public class GameObjectProxy:ProxyBase<GameObject>
    {

        [MoonSharpHidden]
        public GameObjectProxy(GameObject gameObject):base(gameObject)
        {
        }
        public string name => target.name;
        public Vector2 position
        {
            get => target.transform.position;
            set => target.transform.position = value.ToVector3(target.transform.position.z);
        }
    }

    

    class Vector2Proxy
    {
        Vector2 vector;

        [MoonSharpHidden]
        public Vector2Proxy(Vector2 v)
        {
            this.vector = v;
        }

        public float x
        {
            get { return vector.x; }
            set { vector.x = value; }
        }
        public float y
        {
            get { return vector.y; }
            set { vector.y = value; }
        }
        public float magnitude => vector.magnitude;
        public Vector2 normalized => vector.normalized;
    }

    public class CoroutineProxy : ProxyBase<UnityEngine.Coroutine>
    {
        public CoroutineProxy(UnityEngine.Coroutine target) : base(target)
        {
        }
    }

    public class AudioClipProxy : ProxyBase<AudioClip>
    {
        public AudioClipProxy(AudioClip target) : base(target)
        {
        }
    }

    public class CameraProxy : ProxyBase<SceneCamera>
    {
        public CameraProxy(SceneCamera target) : base(target)
        {
        }

        public float Speed
        {
            get => target.GetComponent<CameraFollow>().MaxSpeed;
            set => target.GetComponent<CameraFollow>().MaxSpeed = value;
        }

        public float Acceleration
        {
            get => target.GetComponent<CameraFollow>().MaxAcceleration;
            set => target.GetComponent<CameraFollow>().MaxAcceleration = value;
        }

        public void Follow(GameEntity followTarget)
        {
            target.GetComponent<CameraFollow>().Follow(followTarget?.transform);
        }

        public void Follow(GameEntity[] targets)
        {
            target.GetComponent<CameraFollow>().Follow(targets.Select(target => target.transform).ToArray());
        }

        public void MoveTo(Vector2 pos)
        {
            target.GetComponent<CameraFollow>().focusPosition = pos.ToVector3();
        }

        public void Reset()
        {
            target.GetComponent<CameraFollow>().Follow();
            SceneCamera.Instance.GetComponent<CameraFollow>().ResetPosition(SceneCamera.Instance.ViewportRect.size / 2);
        }
    }

    public class UIPanelProxy<TUIPanel> : ProxyBase<TUIPanel> where TUIPanel: MAJIKA.GUI.UIPanel<TUIPanel>
    {
        public UIPanelProxy(TUIPanel target, LuaScriptHost host) : base(target, host)
        {
        }

        public void Show()
            => target.ShowAsync();

        public void Hide()
            => target.HideAsync();
    }
}
