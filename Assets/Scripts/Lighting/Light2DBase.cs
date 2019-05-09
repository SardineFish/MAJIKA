using UnityEngine;
using System.Collections;
using UnityEngine.Rendering;

namespace Lighting2D
{
    public abstract class Light2DBase : MonoBehaviour
    {
        public abstract void RenderLight(CommandBuffer cmd);
    }
}