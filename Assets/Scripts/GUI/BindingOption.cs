using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAJIKA;

[Serializable]
public class BindingOption
{
    public string PathSource = "";
    public string PathTemplate = "";
    public BindingMode BindingMode = BindingMode.OneWay;
    public MAJIKA.Converter.TypeConverterBase DataConverter;
    public object lastSource = null;
    public object lastRender = null;
}
public enum BindingMode
{
    Static,
    OneWay,
    TwoWay
}
