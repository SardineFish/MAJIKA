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
        public Vector2 Center;
        MaterialPropertyBlock propertyBlock;
        private void Start()
        {
            propertyBlock = new MaterialPropertyBlock();
            ResetTime();
        }

        private void Update()
        {
            propertyBlock.SetVector("_Center", new Vector4(Center.x, Center.y, 0, 1));
            GetComponent<Renderer>().SetPropertyBlock(propertyBlock);
        }

        [EditorButton]
        public void ResetTime()
        {
            Debug.Log("Reset");
            propertyBlock.SetFloat("_StartTime", Time.time);
            GetComponent<Renderer>().SetPropertyBlock(propertyBlock);
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.cyan;
            Gizmos.DrawWireSphere(Center.ToVector3(), 1);
        }
    }
}
