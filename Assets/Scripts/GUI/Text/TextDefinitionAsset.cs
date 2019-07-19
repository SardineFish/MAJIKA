using UnityEngine;
using System.Collections;

namespace MAJIKA.TextManager
{
    public abstract class TextDefinitionAsset : ScriptableObject, ITextDefinition
    {
        public abstract string this[string id] { get; }

        public abstract bool Has(string id);
        public virtual void Reload() { }
    }
}