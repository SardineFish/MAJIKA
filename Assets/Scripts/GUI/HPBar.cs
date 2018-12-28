using UnityEngine;
using System;
using System.Collections;

[RequireComponent(typeof(ValueBar))]
public class HPBar : EntityBehaviour<LifeEntity>
{
    private void Awake()
    {
        Entity.GetComponent<EventBus>().On(LifeEntity.EventDeath, OnDead);
    }
    private void OnDead()
    {
        GetComponent<ValueBar>().gameObject.SetActive(false);
    }
    private void Update()
    {
        var entity = Entity;
        GetComponent<ValueBar>().NormalizedValue = Entity.HP / Entity.MaxHP;
        
    }
}   