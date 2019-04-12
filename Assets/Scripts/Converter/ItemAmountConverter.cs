using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAJIKA.Converter
{
    public class ItemAmountConverter : TypeConverter<int, string>
    {
        public override int ConvertBack(string input)
        {
            throw new NotImplementedException();
        }

        public override string ConvertTo(int input)
        {
            return input > 1 ? input.ToString() : "";
        }
    }
}
