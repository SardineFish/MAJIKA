using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;

[ExecuteInEditMode]
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
    public bool UpdateInEditMode = false;
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
            if (bind.BindingMode == BindingMode.Static)
                return;
            var source = UITemplateUtility.GetValueByPath(dataSource, bind.PathSource);
            var rendered = gameObject.GetValueByPath(bind.PathTemplate);
            if (bind.BindingMode == BindingMode.OneWay)
            {
                if(bind.lastSource != source)
                {
                    gameObject.SetValueByPath(bind.PathTemplate, bind.DataConverter ? bind.DataConverter.ConvertObjectTo(source) : source);
                    bind.lastSource = source;
                    bind.lastRender = gameObject.GetValueByPath(bind.PathTemplate);
                }
            }
            else if (bind.BindingMode == BindingMode.TwoWay)
            {
                if(bind.lastSource != source)
                {
                    gameObject.SetValueByPath(bind.PathTemplate, bind.DataConverter ? bind.DataConverter.ConvertObjectTo(source) : source);
                    bind.lastSource = source;
                    bind.lastRender = gameObject.GetValueByPath(bind.PathTemplate);
                }
                else if (bind.lastRender != rendered)
                {
                    UITemplateUtility.SetValueByPath(ref dataSource, bind.PathSource, rendered);
                    bind.lastSource = UITemplateUtility.GetValueByPath(dataSource, bind.PathSource);
                    bind.lastRender = rendered;
                }
            }
        }
    }

    void Reload()
    {
        foreach (var bind in Bindings)
        {
            bind.lastSource = UITemplateUtility.GetValueByPath(dataSource, bind.PathSource);
            gameObject.SetValueByPath(bind.PathTemplate, bind.DataConverter ? bind.DataConverter.ConvertObjectTo(bind.lastSource) : bind.lastSource);
            bind.lastRender = gameObject.GetValueByPath(bind.PathTemplate);
        }
    }
}