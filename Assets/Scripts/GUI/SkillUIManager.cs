using UnityEngine;
using System.Collections;
using System.Linq;

public class SkillUIManager : MonoBehaviour
{
    public UITemplateRenderer TemplateRenderer;
    public GameEntity DisplayEntity;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (DisplayEntity)
        {
            TemplateRenderer.DataSource = DisplayEntity.GetComponent<SkillController>().Skills;
            GetComponent<CanvasGroup>().alpha = 1;
        }
        else
        {
            GetComponent<CanvasGroup>().alpha = 0;
        }
        
    }
}
