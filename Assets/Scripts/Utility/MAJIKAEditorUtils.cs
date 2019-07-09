using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAJIKA.Utils
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
    public class StatusEffectAttribute : CustomEditorAttribute
    {
        public string Label { get; private set; }
        public StatusEffectAttribute(string label = "") : base()
        {
            Label = label;
        }
    }
}
