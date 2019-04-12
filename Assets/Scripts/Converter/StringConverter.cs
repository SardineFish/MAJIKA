using UnityEngine;
using System.Collections;

namespace MAJIKA.Converter
{
    [CreateAssetMenu(fileName = "StringConverter", menuName = "Converters/StringConverter")]
    public class StringConverter : TypeConverter<object, string>
    {
        public override object ConvertBack(string input)
        {
            throw new System.NotImplementedException();
        }

        public override string ConvertTo(object input)
        {
            if (input == null)
                return "";
            return input.ToString();
        }
    }
}