using UnityEngine;
using System.Collections;

namespace MAJIKA.TextManager
{
    [CreateAssetMenu(fileName = "InputControlTextDefinition", menuName = "TextDefinition/InputControl")]
    public class InputControlTextDefinition : TextDefinitionAsset
    {
        public override string this[string id] => throw new System.NotImplementedException();

        public override bool Has(string id)
        {
            throw new System.NotImplementedException();
        }

        public override void Reload()
        {
            throw new System.NotImplementedException();
        }
    }

}
