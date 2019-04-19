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
        private void Start()
        {
            /*
            InputManager.Instance.AcceptAction.performed += (ctx) =>
            {
                Debug.Log("performed");
            };
            InputManager.Instance.AcceptAction.started += ctx =>
            {
                Debug.Log("started");
            };
            InputManager.Instance.AcceptAction.cancelled += ctx =>
            {
                Debug.Log("cancelled");
            };*/
        }
        private void Update()
        {

            //Debug.Log(InputManager.Instance.AcceptAction.phase);
        }

        private void FixedUpdate()
        {
        }
    }
}
