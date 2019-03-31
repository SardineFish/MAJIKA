using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAJIKA.GUI
{
    public interface IDragable
    {
        DragData OnDrag();
    }
}