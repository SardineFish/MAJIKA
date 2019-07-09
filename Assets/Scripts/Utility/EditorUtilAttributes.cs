using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public abstract class CustomEditorAttribute : Attribute
{

}


[AttributeUsage(AttributeTargets.Method, Inherited = true, AllowMultiple = false)]
public class EditorButtonAttribute : CustomEditorAttribute
{
    public string Label { get; private set; }
    public EditorButtonAttribute(string label = "")
    {
        Label = label;
    }
}

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
public class ReadOnlyAttribute : Attribute
{
    public string Label { get; private set; }
    public ReadOnlyAttribute(string label = ""): base()
    {
        Label = label;
    }
}