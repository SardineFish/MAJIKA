using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using System.Reflection;

[Serializable]
public class EventResponse
{
    public string Event;
    public List<ComponentResponsor> Targets = new List<ComponentResponsor>();

    public void Handle(GameObject gameObject)
    {
        foreach(var responsor in Targets)
        {
            var component = gameObject.GetComponent(responsor.ComponentName);
            var method = component.GetType()
                .GetMethods(BindingFlags.Instance | BindingFlags.Public)
                .Where(m => m.Name == responsor.MethodName)
                .Where(m => m.GetParameters().Length <= 0)
                .FirstOrDefault();
            method?.Invoke(component, null);
        }
    }
}

[Serializable]
public class ComponentResponsor
{
    public string ComponentName;
    public string MethodName;
}