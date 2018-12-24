using UnityEngine;
using System.Collections;
using System.Linq;

public class SkillUIManager : MonoBehaviour
{
    public UITemplateRenderer TemplateRenderer;
    // Use this for initialization
    void Start()
    {
        if (GameSystem.Instance.PlayerInControl)
            this.NextFrame(() =>
            {
                TemplateRenderer.DataSource = GameSystem.Instance.PlayerInControl.GetComponent<SkillController>().Skills;
            });
    }

    // Update is called once per frame
    void Update()
    {

    }
}
