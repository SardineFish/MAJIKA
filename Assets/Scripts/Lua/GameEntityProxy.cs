using MoonSharp.Interpreter;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace LuaHost.Proxy
{
    class GameEntityProxy : ProxyBase<GameEntity>
    {
        [MoonSharpHidden]
        public GameEntityProxy(GameEntity entity) : base(entity)
        {
            //entity.OnUpdate += EntityUpdate;
        }

        public float HP => (target as LifeEntity)?.HP ?? 0;
        
        public Vector2 Position
        {
            get
            {
                return target.transform.position.ToVector2();
            }
            set
            {
                target.transform.position = target.transform.position.Set(x: value.x, y: value.y);
            }
        }
        public bool Skill(int idx, float dir)
            => target.GetComponent<EntityController>()?.Skill(idx, dir) ?? false;
        public void Move(Vector2 movement)
            => target.GetComponent<EntityController>()?.Move(movement);
        public void Jump() 
            => target.GetComponent<EntityController>()?.Jump();
        public void Climb(float speed) 
            => target.GetComponent<EntityController>()?.Climb(speed);
        

        private IEnumerator WaitInternal(string target)
        {

            switch (target)
            {
                case "skill":
                    yield return this.target.GetComponent<SkillController>().WaitSkill();
                    break;
                case "animation":
                case "action":
                    yield return this.target.GetComponent<AnimationController>().WaitAnimation();
                    break;
            }
        }
        
        public UnityEngine.Coroutine Wait(string target, LuaScriptHost host)
        {
            return host.StartCoroutine(WaitInternal(target));   
        }

        public Threat[] DetectThreat()
            => target.DetectThreat();
    }
}
