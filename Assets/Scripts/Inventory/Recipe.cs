using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public class Recipe
    {
        public Item Product;
        public List<Item> Materials = new List<Item>();

        public override string ToString()
        {
            return $"{(this.Product ? this.Product.DisplayName : "?")} = {String.Join(" + ", Materials.Select(m => m.DisplayName))}";
        }
    }
}
