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
        Dictionary<Camera, Light2DProfile> commandBuffers = new Dictionary<Camera, Light2DProfile>();
        public int BloomIteration = 2;

        // Use this for initialization
        void Start()
        {
            commandBuffers = new Dictionary<Camera, Light2DProfile>();
            if (!LightingMaterial)
                LightingMaterial = new Material(Shader.Find("Lighting2D/DeferredLighting"));
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

            var gbuffer0ID = Shader.PropertyToID("_Diffuse");
            var lightMap = profile.LightMap;

            cmd.GetTemporaryRT(gbuffer0ID, -1, -1);
            cmd.Blit(BuiltinRenderTextureType.CameraTarget, gbuffer0ID);

            cmd.SetRenderTarget(lightMap);
            cmd.ClearRenderTarget(false, true, Color.black);

            // Render sprite light
            var spriteLights = FindObjectsOfType<SpriteLight>();
            foreach (var light in spriteLights)
            {
                light.RenderLight(cmd);
            }

            var temp = RenderTexture.GetTemporary(camera.pixelWidth / 16, camera.pixelHeight / 16, 0, RenderTextureFormat.ARGBFloat);
            temp.filterMode = FilterMode.Trilinear;
            for (var i = 0; i < BloomIteration; i++)
            {
                cmd.Blit(lightMap, temp, LightingMaterial, 1);
                cmd.Blit(temp, lightMap, LightingMaterial, 1);
            }
            temp.DiscardContents();
            RenderTexture.ReleaseTemporary(temp);

            
            var lights = GameObject.FindObjectsOfType<Light2D>();
            foreach (var light in lights)
            {
                light.RenderLight(cmd);
            }
            cmd.SetRenderTarget(BuiltinRenderTextureType.CameraTarget, BuiltinRenderTextureType.CameraTarget);
            

            cmd.Blit(lightMap, BuiltinRenderTextureType.CameraTarget, LightingMaterial, 0);
            cmd.ReleaseTemporaryRT(gbuffer0ID);
            
            //cmd.ReleaseTemporaryRT(lightID);
            cmd.SetRenderTarget(BuiltinRenderTextureType.CameraTarget);
        }
    }

}