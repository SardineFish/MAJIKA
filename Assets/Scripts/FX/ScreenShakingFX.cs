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
            MainCamera.Instance.GetComponent<CameraShake>().Enabled = true;
        }

        private void Update()
        {
            MainCamera.Instance.GetComponent<CameraShake>().Frequence = Frequence;
            MainCamera.Instance.GetComponent<CameraShake>().Strength = Strength;
        }

        private void OnDestroy()
        {
            MainCamera.Instance.GetComponent<CameraShake>().Enabled = false;
        }
    }

}
