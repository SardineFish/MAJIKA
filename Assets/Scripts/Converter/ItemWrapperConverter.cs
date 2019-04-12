using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory;
using UnityEngine;

namespace MAJIKA.Converter
{

    [CreateAssetMenu(fileName = "ItemWrapperConverter", menuName = "Converters/ItemWrapper")]
    public class ItemWrapperConverter : TypeConverter<Item, ItemWrapper>
    {
        public override Item ConvertBack(ItemWrapper input)
        {
            return input.Item;
        }

        public override ItemWrapper ConvertTo(Item input)
        {
            return new ItemWrapper()
            {
                Item = input,
                Amount = 1
            };

        }
    }
}
