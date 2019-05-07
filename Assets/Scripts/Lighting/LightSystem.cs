using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Rendering;

namespace Lighting2D
{
    [ExecuteInEditMode]
    [RequireComponent(typeof(MeshRenderer))]
    public class LightSystem : Singleton<LightSystem>
    {
        public Material LightingMaterial;
        public RenderTexture lightMap;
        Dictionary<Camera, Light2DProfile> commandBuffers = new Dictionary<Camera, Light2DProfile>();
        // Use this for initialization
        void Start()
        {
            commandBuffers = new Dictionary<Camera, Light2DProfile>();
        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnWillRenderObject()
        {
            var camera = Camera.current;
            var profile = SetupCamera(camera);
            RenderDeffer(profile);
        }

        public Light2DProfile SetupCamera(Camera camera)
        {
            if (!commandBuffers.ContainsKey(camera))
            {
                camera.RemoveAllCommandBuffers();
                var profile = new Light2DProfile()
                {
                    Camera = camera,
                    CommandBuffer = new CommandBuffer(),
                    LightMap = new RenderTexture(camera.pixelWidth, camera.pixelHeight, 0, RenderTextureFormat.ARGBFloat),
                };
                commandBuffers[camera] = profile;
                profile.CommandBuffer.name = "2D Lighting";
                profile.LightMap.name = "Light Map";
                camera.AddCommandBuffer(CameraEvent.BeforeImageEffects, profile.CommandBuffer);
            }
            return commandBuffers[camera];
        }

        public void RenderDeffer(Light2DProfile profile)
        {
            var camera = profile.Camera;
            var cmd = profile.CommandBuffer;
            cmd.Clear();
            //cmd.Blit(BuiltinRenderTextureType.CameraTarget, )
            var gbuffer0ID = Shader.PropertyToID("_Diffuse");
            //var lightID = Shader.PropertyToID("_Lighting");
            var lightMap = profile.LightMap;

            cmd.GetTemporaryRT(gbuffer0ID, -1, -1);
            //cmd.GetTemporaryRT(lightID, -1, -1);
            cmd.Blit(BuiltinRenderTextureType.CameraTarget, BuiltinRenderTextureType.GBuffer0);
            cmd.Blit(BuiltinRenderTextureType.GBuffer0, gbuffer0ID);

            cmd.SetRenderTarget(lightMap);
            cmd.ClearRenderTarget(false, true, Color.black);
            
            var lights = GameObject.FindObjectsOfType<Light2D>();
            foreach (var light in lights)
            {
                //cmd.SetGlobalTexture("_GBuffer1", BuiltinRenderTextureType.GBuffer0);
                light.RenderLight(cmd);
            }
            cmd.SetRenderTarget(BuiltinRenderTextureType.CameraTarget, BuiltinRenderTextureType.CameraTarget);

            //cmd.Blit(BuiltinRenderTextureType.GBuffer3, lightID);

            cmd.Blit(lightMap, BuiltinRenderTextureType.CameraTarget, LightingMaterial);
            cmd.ReleaseTemporaryRT(gbuffer0ID);
            //cmd.ReleaseTemporaryRT(lightID);
            cmd.SetRenderTarget(BuiltinRenderTextureType.CameraTarget);
        }
    }

}