using UnityEngine;
using System.Collections;

public class UITemplateRenderer : MonoBehaviour
{
    public GameObject Template;
    object dataSource;
    public object DataSource
    {
        get { return dataSource; }
        set
        {
            if (dataSource != value)
                SetDataSource(value);
        }
    }
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetDataSource(object dataSource)
    {
        this.dataSource = dataSource;
        foreach(var obj in gameObject.GetChildren())
        {
            Destroy(obj);
        }
        if (DataSource != null)
        {
            if (DataSource is IList)
            {
                var dataList = DataSource as IList;
                foreach (var item in dataList)
                {
                    var obj = Instantiate(Template);
                    obj.transform.SetParent(transform);
                    obj.GetComponent<UITemplate>().DataSource = item;
                }
            }
            else
            {
                var obj = Instantiate(Template);
                obj.transform.SetParent(transform);
                obj.GetComponent<UITemplate>().DataSource = DataSource;
            }

        }
    }
}
