using MoonSharp.Interpreter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace LuaHost
{
    [MoonSharpUserData]
    public class SceneHost
    {
        public GameEntity Entity(string name)
        {
            return Utility.Times(SceneManager.sceneCount)
                .SelectMany(i=>SceneManager.GetSceneAt(i).GetRootGameObjects())
                .Where(obj => obj.name == name)
                .Select(obj => obj.GetComponent<GameEntity>())
                .FirstOrDefault();
            // return GameObject.Find(name).GetComponent<GameEntity>();
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
    }
}
