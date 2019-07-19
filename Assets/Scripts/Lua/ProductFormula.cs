using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory;
using UnityEngine;
using MoonSharp.Interpreter;

namespace MAJIKA.Lua
{
    [MoonSharpUserData]
    public class ProductFormula
    {
        public Item Material;
        public ProductFormula Next;
        
        public static ProductFormula operator +(ProductFormula f1, ProductFormula f2)
        {
            ProductFormula p;
            for (p = f1; p.Next != null; p = p.Next) ;
            p.Next = f2;
            return f1;
        }

        public static implicit operator ProductFormula(Item item)
        {
            return new ProductFormula()
            {
                Material = item,
                Next = null
            };
        }
    }
}
