using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public static class UITemplateUtility
{
    public static object GetValueByPath(this GameObject obj, string path)
    {
        if (obj == null)
            return null;
        if (path == "")
            return obj;
        var paths = path.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
        if (paths.Length <= 0)
            return null;
        var component = obj.GetComponent(paths[0]);
        object currentObj = component;
        MemberInfo current = component.GetType().GetMember(paths[1]).FirstOrDefault();
        for (var i = 2; i < paths.Length; i++)
        {
            if (current.MemberType == MemberTypes.Field)
                currentObj = (current as FieldInfo).GetValue(currentObj);
            else if (current.MemberType == MemberTypes.Property)
                currentObj = (current as PropertyInfo).GetValue(currentObj);
            current = currentObj.GetType().GetMember(paths[i]).FirstOrDefault();
        }
        return currentObj;
    }

    public static object SetValueByPath(this GameObject obj, string path, object value)
    {
        if (obj == null)
            return null;
        if (path == "")
            return null;
        var paths = path.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
        if (paths.Length <= 0)
            return null;
        var component = obj.GetComponent(paths[0]);
        object currentObj = component;
        MemberInfo current = component.GetType().GetMember(paths[1]).FirstOrDefault();
        
        for (var i = 2; i < paths.Length; i++)
        {
            if (current.MemberType == MemberTypes.Field)
                currentObj = (current as FieldInfo).GetValue(currentObj);
            else if (current.MemberType == MemberTypes.Property)
                currentObj = (current as PropertyInfo).GetValue(currentObj);
            current = currentObj.GetType().GetMember(paths[i]).FirstOrDefault();
        }

        if (current.MemberType == MemberTypes.Field)
            (current as FieldInfo).SetValue(currentObj, value);
        else if (current.MemberType == MemberTypes.Property)
            (current as PropertyInfo).SetValue(currentObj, value);

        return value;
    }

    public static object GetValueByPath(object obj, string path)
    {
        if (obj == null)
            return null;
        if (path == "")
            return obj;
        var paths = path.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
        if (paths.Length <= 0)
            return null;
        object value = obj;
        for(var i = 0; i < paths.Length; i++)
        {
            value = value.GetType().GetField(paths[i]).GetValue(value);
        }
        return value;
    }

    public static object SetValueByPath(ref object obj,string path, object value)
    {
        if (obj == null)
            return null;
        if (path == "")
            obj = path;
        var paths = path.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
        if (paths.Length <= 0)
            return null;
        object currentObj = obj;
        FieldInfo current = obj.GetType().GetField(paths[0]);
        for(var i=1;i<paths.Length;i++)
        {
            currentObj = current.GetValue(currentObj);
            current = currentObj.GetType().GetField(paths[i]);
        }
        current.SetValue(currentObj, value);
        return value;
    }
}