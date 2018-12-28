using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TargetUI : MonoBehaviour
{
    public Text TextName;
    public HPBar HPBar;
    public GameEntity Target;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        HPBar.DisplayEntity = Target as LifeEntity;
        if (Target)
        {
            GetComponent<CanvasGroup>().alpha = 1;
        }
        else
        {
            GetComponent<CanvasGroup>().alpha = 0;
        }
    }

    public void SetTarget(string name, GameEntity target)
    {
        TextName.text = name;
        Target = target;
    }
    
}
