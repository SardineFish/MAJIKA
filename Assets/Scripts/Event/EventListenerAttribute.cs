using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[System.AttributeUsage(AttributeTargets.Method, Inherited = true, AllowMultiple = false)]
public class EventListenerAttribute : Attribute
{
    public EventListenerAttribute(string eventName)
    {
        EventName = eventName;
    }

    public string EventName { get; set; }
}