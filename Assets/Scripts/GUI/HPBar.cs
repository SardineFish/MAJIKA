using UnityEngine;
using System;
using System.Collections;

[RequireComponent(typeof(ValueBar))]
public class HPBar: MonoBehaviour
{
    public LifeEntity DisplayEntity;
    private void Awake()
    {
        //DisplayEntity.GetComponent<EventBus>().On(LifeEntity.EventDeath, OnDead);
    }
    private void OnDead()
    {
        GetComponent<ValueBar>().gameObject.SetActive(false);
    }
    private void Update()
    {
        if (DisplayEntity)
        {
            var hp = DisplayEntity.HP / DisplayEntity.MaxHP;

            GetComponent<ValueBar>().NormalizedValue = hp;
            if (hp <= 0)
                GetComponent<CanvasGroup>().alpha = 0;
            else
                GetComponent<CanvasGroup>().alpha = 1;
        }
        else
        {
            GetComponent<CanvasGroup>().alpha = 0;
        }
    }
}   