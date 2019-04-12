using UnityEngine;
using System.Collections;

namespace MAJIKA.Converter
{
    public abstract class TypeConverter<TInput, TOutput> : TypeConverterBase
    {
        public abstract TOutput ConvertTo(TInput input);
        public override object ConvertTo(object input)
        {
            return ConvertTo((TInput)input);
        }

        public abstract TInput ConvertBack(TOutput input);
        public override object ConvertBack(object input)
        {
            return ConvertBack((TOutput)input);
        }
    }

    public abstract class TypeConverterBase: ScriptableObject
    {
        public abstract object ConvertTo(object input);
        public abstract object ConvertBack(object input);
    }
}

