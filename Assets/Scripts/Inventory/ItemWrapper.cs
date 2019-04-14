using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    [Serializable]
    public class ItemWrapper
    {
        public Item Item = null;
        public int Amount = 0;
    }
}
