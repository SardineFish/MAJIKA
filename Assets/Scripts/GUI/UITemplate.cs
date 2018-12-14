using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;

public class UITemplate : MonoBehaviour
{
    object dataSource;
    public object DataSource
    {
        get
        {
            return dataSource;
        }
        set
        {
            var old = dataSource;
            dataSource = value;
            if (old != value)
            {
                Reload();
                GetComponentsInChildren<UITemplate>().ForEach(template => template.DataSource = value);
            }
        }
    }
    public List<BindingOption> Bindings = new List<BindingOption>();
    // Use this for initialization
    void Start()
    {
        Reload();
    }

    // Update is called once per frame
    void Update()
    {
        if (!Application.isPlaying)
        {
            GetComponentsInChildren<UIBehaviour>().ForEach((ui) =>
            {
                if (!ui.GetComponent<UITemplate>())
                    ui.gameObject.AddComponent<UITemplate>();
            });
        }
        foreach (var bind in Bindings)
        {
            if(bind.BindingMode == BindingMode.OneWay)
            {
                gameObject.SetValueByPath(bind.PathTemplate, UITemplateUtility.GetValueByPath(dataSource, bind.PathSource));
                //UITemplateUtility.SetValueByPath(gameObject, bind.PathTemplate, UITemplateUtility.GetValueByPath(dataSource, bind.PathSource));
            }
        }
    }

    void Reload()
    {
        if (DataSource == null)
            return;
        foreach (var bind in Bindings)
        {
            gameObject.SetValueByPath(bind.PathTemplate, UITemplateUtility.GetValueByPath(dataSource, bind.PathSource));
        }
    }
}