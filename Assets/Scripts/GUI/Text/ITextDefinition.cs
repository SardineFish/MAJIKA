using UnityEngine;
using System.Collections;

namespace MAJIKA.TextManager
{
    public interface ITextDefinition
    {
        string this[string id] { get; }

        bool Has(string id);
    }

}
