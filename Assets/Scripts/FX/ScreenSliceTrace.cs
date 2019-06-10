using UnityEngine;
using System.Collections;
using System.Linq;

namespace MAJIKA.FX
{
    public class ScreenSliceTrace : MonoBehaviour
    {
        public static Vector2 LastDir;
        // Use this for initialization
        void Start()
        {
            var platforms = GameObject.FindGameObjectsWithTag("Platform");
            platforms = platforms.RandomTake(2).ToArray();
            var dir = (platforms[1].transform.position - platforms[0].transform.position).ToVector2();
            if (Vector2.Dot(LastDir, dir) > 0)
                dir = -dir;
            var pos = (platforms[1].transform.position + platforms[0].transform.position).ToVector2() / 2;
            pos += Vector2.up * 2;
            transform.Rotate(0, 0, MathUtility.ToAng(dir));
            transform.parent.position = pos.ToVector3(transform.position.z);
            LastDir = dir;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}