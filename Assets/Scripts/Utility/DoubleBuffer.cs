using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DoubleBuffer<T>
{
    private T value;
    public T Value
    {
        get => value;
        set => BackendValue = value;
    }

    public T BackendValue { get; private set; }

    public void Reset()
    {
        BackendValue = default;
    }

    public T Update()
    {
        value = BackendValue;
        return value;
    }
    public T ForceUpdate(T value)
    {
        value = BackendValue = value;
        return value;
    }
}