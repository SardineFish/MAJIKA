using UnityEngine;
using System.Collections;

namespace MAJIKA.FX
{
    public class FullScreenFX : MonoBehaviour
    {
        // Use this for initialization
        void Start()
        {
            Update();
        }

        // Update is called once per frame
        void Update()
        {
            var camera = MainCamera.Instance.Camera;
            transform.localScale = new Vector3(MainCamera.Instance.ViewportRect.width, MainCamera.Instance.ViewportRect.height, 1);
            transform.position = new Vector3(camera.transform.position.x, camera.transform.position.y, transform.position.z);
        }
    }

}

