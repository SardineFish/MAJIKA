using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using MoonSharp.Interpreter;

namespace LuaHost.Proxy
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

    public class CameraProxy : ProxyBase<Camera>
    {
        public CameraProxy(Camera target) : base(target)
        {
        }

        public float Speed
        {
            get => target.GetComponent<CameraMovement>().MaxSpeed;
            set => target.GetComponent<CameraMovement>().MaxSpeed = value;
        }

        public float Acceleration
        {
            get => target.GetComponent<CameraMovement>().MaxAcceleration;
            set => target.GetComponent<CameraMovement>().MaxAcceleration = value;
        }

        public void Follow(GameEntity followTarget)
        {
            target.GetComponent<CameraMovement>().followTarget = followTarget.transform; 
        }

        public void MoveTo(Vector2 pos)
        {
            target.GetComponent<CameraMovement>().focusPosition = pos.ToVector3();
        }

        public void Reset()
        {
            target.GetComponent<CameraMovement>().followTarget = null;
            target.transform.position = (target.GetComponent<CameraMovement>().ViewportRect.size / 2).ToVector3(target.transform.position.z);
        }
    }

    public class UIPanelProxy<TUIPanel> : ProxyBase<TUIPanel> where TUIPanel: MAJIKA.GUI.UIPanel<TUIPanel>
    {
        public UIPanelProxy(TUIPanel target, LuaScriptHost host) : base(target, host)
        {
        }

        public void Show()
            => target.Show();

        public void Hide()
            => target.Hide();
    }
}
