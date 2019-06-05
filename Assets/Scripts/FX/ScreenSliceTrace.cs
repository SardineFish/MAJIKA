using UnityEngine;
using System.Collections;

namespace MAJIKA.FX
{
    public class ScreenSliceTrace : MonoBehaviour
    {
        static float ang = 0;
        // Use this for initialization
        void Start()
        {
            ang = ang + 180 + (Random.value * 2 - 1) * 90;
            transform.Rotate(0, 0, ang);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}