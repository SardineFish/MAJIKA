using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEditor;

namespace Assets.Editor
{
    class SpriteSheetImporter : AssetPostprocessor
    {
        void OnPostprocessTexture(Texture2D texture)
        {
            var textureImporter = assetImporter as TextureImporter; 
        }
    }
}
