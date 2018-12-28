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
    public class ResourcesHost
    {
        public GameObject Prefab(string name)
        {
            
            return Resources.Load<GameObject>($"Prefabs/{name}");
        }

        public AudioClip Audio(string name)
        {
            return Resources.Load<AudioClip>($"Audio/{name}");
        }
    }
}
