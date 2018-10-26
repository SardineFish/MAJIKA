using UnityEngine;
using System;

[RequireComponent(typeof(ValueBar))]
public class HPBar : EntityBehaviour<LifeEntity>
{
    private void Update()
    {
        var entity = Entity;
        GetComponent<ValueBar>().NormalizedValue = Entity.HP / Entity.MaxHP;
    }
}   