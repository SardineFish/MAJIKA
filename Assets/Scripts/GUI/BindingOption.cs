using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[Serializable]
public class BindingOption
{
    public string PathSource = "";
    public string PathTemplate = "";
    public BindingMode BindingMode = BindingMode.TwoWay;
    public Func<object, object> DataConverter = obj => obj;
    public object lastSource = null;
    public object lastRender = null;
}
public enum BindingMode
{
    Static,
    OneWay,
    TwoWay
}
