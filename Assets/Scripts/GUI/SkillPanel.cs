using UnityEngine;
using System.Collections;

public class SkillPanel : MonoBehaviour
{
    public GameObject Skill;
    public GameObject Equipment;

    public void ShowSkillPanel()
    {
        Equipment.SetActive(false);
        Skill.SetActive(true);
    }

    public void ShowEquipmentPanel()
    {
        Skill.SetActive(false);
        Equipment.SetActive(true);
    }
}
