using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEditor;
using System.IO;


namespace Assets.Editor
{
    class SpriteSheetImporter : AssetPostprocessor
    {
        void OnPostprocessTexture(Texture2D texture)
        {
            var importer = assetImporter as TextureImporter;
            importer.spritePixelsPerUnit = 16;
            importer.filterMode = FilterMode.Point;
            importer.spriteImportMode = SpriteImportMode.Multiple;
            return;
            importer.spritePixelsPerUnit = 16;
            importer.filterMode = FilterMode.Point;
            importer.compressionQuality = 0;

            var textureName = Path.GetFileNameWithoutExtension(importer.assetPath);
            var jsonPath = Path.Combine(Application.dataPath.Replace("Assets",""), Path.Combine(Path.GetDirectoryName(importer.assetPath), $"{Path.GetFileNameWithoutExtension(importer.assetPath)}.json"));
            if (File.Exists(jsonPath))
            {
                SpriteSheetData data;
                using (var fs = new FileStream(jsonPath, FileMode.Open))
                using (var sr = new StreamReader(fs))
                {
                    var jsonText = sr.ReadToEnd();
                    data = JsonUtility.FromJson<SpriteSheetData>(jsonText);
                    sr.Close();
                    fs.Close();
                }
                importer.spriteImportMode = SpriteImportMode.Multiple;
                importer.spritesheet = new SpriteMetaData[data.sprites.Length];
                var spriteSheet = new SpriteMetaData[data.sprites.Length];
                for(var i = 0; i < data.sprites.Length; i++)
                {
                    var sprite = new SpriteMetaData();
                    sprite.rect = new Rect(data.sprites[i].x, data.sprites[i].y, data.sprites[i].width, data.sprites[i].height);
                    sprite.name = $"{textureName}_{i}";
                    
                    spriteSheet[i] = sprite;
                }
                importer.spritesheet = spriteSheet;
            }
        }
    }
}
