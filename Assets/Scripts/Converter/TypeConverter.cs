using UnityEngine;
using System.Collections;

namespace MAJIKA.Converter
{
    public abstract class TypeConverter<TInput, TOutput> : TypeConverterBase
    {
        public abstract TOutput ConvertTo(TInput input);
        public override object ConvertObjectTo(object input)
        {
            return ConvertTo((TInput)input);
        }

        public abstract TInput ConvertBack(TOutput input);
        public override object ConvertObjectBack(object input)
        {
            return ConvertBack((TOutput)input);
        }
    }

    public abstract class TypeConverterBase: ScriptableObject
    {
        public abstract object ConvertObjectTo(object input);
        public abstract object ConvertObjectBack(object input);
    }
}

