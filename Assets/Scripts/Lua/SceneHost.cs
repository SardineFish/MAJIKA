using MoonSharp.Interpreter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Timeline;

namespace LuaHost
{
    [MoonSharpUserData]
    public class SceneHost
    {
        public GameEntity Entity(string name)
        {
            var entity = EntityManager.FindEntity<GameEntity>(name);
            return entity; 

            // return Utility.Times(SceneManager.sceneCount)
            //     .SelectMany(i=>SceneManager.GetSceneAt(i).GetRootGameObjects())
            //     .Where(obj => obj.name == name)
            //     .Select(obj => obj.GetComponent<GameEntity>())
            //     .FirstOrDefault();
            // return GameObject.Find(name).GetComponent<GameEntity>();
        } 

        public GameObject Object(string name)
        {
            return GameObject.Find(name);
        }
        public GameEntity Spawn(GameObject prefab, string name, Vector2 position)
        {
            if (prefab.GetComponent<GameEntity>())
            {
                var obj = GameObject.Instantiate(prefab, position.ToVector3(), Quaternion.identity);
                obj.name = name;
                return obj.GetComponent<GameEntity>();
            }
            return null;
        }
        public void Event(string eventName)
        {
            Level.Instance.GetComponent<EventBus>().Dispatch(eventName);
        }
    }
}
