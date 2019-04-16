using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;

[RequireComponent(typeof(Player))]
public class InputActionController : EntityBehaviour<Player>
{
    public List<InteractiveEntity> InteractiveEntities = new List<InteractiveEntity>();

    private void Update()
    {
        if (InputManager.Instance.GetActionPerformed(InputManager.Instance.InteractAction) && InteractiveEntities.Count > 0)
        {
            InteractiveEntities[0].Interact(Entity);
            //Entity.GetComponent<PlayerController>().playerFSM.ChangeState(PlayerState.Interact);
        }
        else if(InputManager.Instance.GetActionPerformed(InputManager.Instance.InventoryAction))
        {
            MAJIKA.GUI.InventoryPanel.Instance?.Show();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var interactObj = GameEntity.GetEntity(collision)?.GetComponent<InteractiveEntity>();
        if (interactObj != null && !InteractiveEntities.Contains(interactObj))
        {
            InteractiveEntities.Add(interactObj);
            interactObj.ContactEnter(Entity);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        var interactObj = GameEntity.GetEntity(collision)?.GetComponent<InteractiveEntity>();
        if (interactObj != null && InteractiveEntities.Contains(interactObj))
        {
            InteractiveEntities.Remove(interactObj);
            interactObj.ContactExit(Entity);
        }
    }
}
