using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Testing
{
    public class Test:MonoBehaviour
    {
        public float FloatValue;
        private void Start()
        {
        }
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.F1))
                LevelLoader.Instance.LoadLevelDetach("Camp");
            else if (Input.GetKeyDown(KeyCode.F2))
                LevelLoader.Instance.LoadLevelDetach("Tutorial");
            else if (Input.GetKeyDown(KeyCode.F3))
                LevelLoader.Instance.LoadLevelDetach("Level-2");
            else if (Input.GetKeyDown(KeyCode.F4))
                LevelLoader.Instance.LoadLevelDetach("Level-3");
            else if (Input.GetKeyDown(KeyCode.F5))
                LevelLoader.Instance.LoadLevelDetach("Level-4");
        }

        private void FixedUpdate()
        {
        }
    }
}
