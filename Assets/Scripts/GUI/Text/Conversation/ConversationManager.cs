using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using YamlDotNet.Serialization;

namespace MAJIKA.TextManager
{
    [CreateAssetMenu(fileName ="ConversationManager", menuName ="GameSystem/ConversationManager")]
    public class ConversationManager : SingletonAsset<ConversationManager>
    {
        [SerializeField]
        List<TextAsset> ConversationDefinitionAsset = new List<TextAsset>();

        Dictionary<string, ConversationRenderer> ConversationDefinitions = new Dictionary<string, ConversationRenderer>();
        private void OnEnable()
        {
            Reload();
        }

        public void Reload()
        {
            ConversationDefinitions.Clear();
            var deserializer = new Deserializer();
            ConversationDefinitionAsset
                .Where(asset => asset)
                .Select(asset => deserializer.Deserialize<Dictionary<string, string[]>>(asset.text))
                .ForEach(dict =>
                {
                    dict.ForEach(pair => ConversationDefinitions[pair.Key] = new ConversationRenderer(pair.Value));
                });
            Debug.Log($"Loaded {ConversationDefinitions.Count} conversation definitions.");
        }
        
        public static ConversationRenderer GetConversation(string id)
        {
            ConversationRenderer conversation = null;
            Asset?.ConversationDefinitions?.TryGetValue(id, out conversation);
            return conversation;
        }
    }
}