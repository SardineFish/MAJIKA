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

    Skill[] lastUpdate = new Skill[0];
    // Update is called once per frame
    void Update()
    {
        if (DisplayEntity)
        {
            var skills = DisplayEntity.GetComponent<SkillController>().Skills;
            if(!lastUpdate.Diff(skills))
            {
                TemplateRenderer.DataSource = DisplayEntity.GetComponent<SkillController>().Skills;
                lastUpdate = skills;
            }
            //GetComponent<CanvasGroup>().alpha = 1;
        }
        else
        {
            //GetComponent<CanvasGroup>().alpha = 0;
        }
        
    }
}
