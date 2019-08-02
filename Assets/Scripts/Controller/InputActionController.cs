using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;

[RequireComponent(typeof(Player), typeof(EntityController))]
public class InputActionController : EntityBehaviour
{
    public List<InteractiveEntity> InteractiveEntities = new List<InteractiveEntity>();

    private void Update()
    {
        if (InputManager.Instance.Controller.Actions.Interact.WasPressedThisFrame())
        {
            Interact();
        }
        else if(InputManager.Instance.Actions.Inventory.WasPressedThisFrame())
        {
            OpenInventory();
        }
    }

    public bool Interact()
    {
        if (Entity.GetComponent<EntityController>().Locker.Locked)
            return false;
        if(!GetComponent<EntityController>().Locker.Locked && InteractiveEntities.Count > 0)
        {
            InteractiveEntities[0].Interact(Entity);
            return true;
        }
        return false;

    }

    public bool OpenInventory()
    {
        if (MAJIKA.GUI.InventoryPanel.Instance.Visible)
            MAJIKA.GUI.InventoryPanel.Instance?.HideAsync();
        else if (GetComponent<EntityController>().Locker.Locked)
            return false;
        else
            MAJIKA.GUI.InventoryPanel.Instance?.ShowAsync();
        return true;
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
