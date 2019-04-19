using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class InteractHover : EntityBehaviour<GameEntity>
{
    private void Awake()
    {
        Entity.GetComponent<EventBus>().On(InteractiveEntity.EventContactEnter, OnContactEnter);
        Entity.GetComponent<EventBus>().On(InteractiveEntity.EventContactExit, OnContactExit);
        gameObject.SetActive(false);
    }
    bool contact = false;

    void OnContactEnter()
    {
        contact = true;
        gameObject.SetActive(true);
    }

    void OnContactExit()
    {
        contact = false;
        gameObject.SetActive(false);
    }
    private void OnMouseDown()
    {
        if (contact)
        {
            Entity.GetComponent<InteractiveEntity>().ContactEntity?.GetComponent<InputActionController>().Interact();
        }
    }
}
