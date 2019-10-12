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
    [UnityEngine.Serialization.FormerlySerializedAs("Targets")]
    public List<ComponentEventHandler> Handlers = new List<ComponentEventHandler>();

    public void Handle(GameObject gameObject)
    {
        foreach(var responsor in Handlers)
        {
            var component = gameObject.GetComponents<Component>()
                .Where(cpn => cpn.GetType().Name == responsor.ComponentName)
                .FirstOrDefault();
            var method = component.GetType()
                .GetMethods(BindingFlags.Instance | BindingFlags.Public)
                .Where(m => m.Name == responsor.MethodName)
                .Where(m => m.GetParameters().Where(p=>!p.HasDefaultValue).Count() <= 0)
                .FirstOrDefault();
            method?.Invoke(component, method.GetParameters().Select(p=>p.DefaultValue).ToArray());
        }
    }
}

[Serializable]
public class ComponentEventHandler
{
    public string ComponentName;
    public string MethodName;
}