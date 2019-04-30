using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace MAJIKA.FX
{
    [ExecuteInEditMode]
    public class EffectWave : MonoBehaviour
    {
        public Transform Center;
        MaterialPropertyBlock propertyBlock;
        private void Reset()
        {
            propertyBlock = new MaterialPropertyBlock();
        }
        private void Start()
        {
            propertyBlock = new MaterialPropertyBlock();
            ResetTime();
        }

        private void Update()
        {
            propertyBlock.SetVector("_Center", new Vector4(Center.position.x, Center.position.y, 0, 1));
            GetComponent<Renderer>().SetPropertyBlock(propertyBlock);
        }

        [EditorButton]
        public void ResetTime()
        {
            // Debug.Log($"Reset At {Time.time} {Time.unscaledTime} {Time.fixedTime} {Time.fixedUnscaledTime}");
            propertyBlock.SetFloat("_StartTime", Time.timeSinceLevelLoad);
            propertyBlock.SetVector("_Center", new Vector4(Center.position.x, Center.position.y, 0, 1));
            GetComponent<Renderer>().SetPropertyBlock(propertyBlock);
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.cyan;
            Gizmos.DrawWireSphere(Center.position, 1);
        }
    }
}
