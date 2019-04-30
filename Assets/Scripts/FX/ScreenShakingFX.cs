using UnityEngine;
using System.Collections;

namespace MAJIKA.FX
{
    public class ScreenShakingFX : MonoBehaviour
    {
        public float Strength = 1;
        public float Frequence = 1;
        // Use this for initialization
        void Start()
        {
            SceneCamera.Instance.GetComponent<CameraShake>().Enabled = true;
        }

        private void Update()
        {
            SceneCamera.Instance.GetComponent<CameraShake>().Frequence = Frequence;
            SceneCamera.Instance.GetComponent<CameraShake>().Strength = Strength;
        }

        private void OnDestroy()
        {
            SceneCamera.Instance.GetComponent<CameraShake>().Enabled = false;
        }
    }

}
