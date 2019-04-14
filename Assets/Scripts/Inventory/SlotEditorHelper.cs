using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    [System.AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
    public class SlotAttribute : Attribute
    {
        string name;
        public string Name => name;
        public SlotAttribute(string name)
        {
            this.name = name;
        }

    }

    public interface ISlotEditor
    {

    }
}
