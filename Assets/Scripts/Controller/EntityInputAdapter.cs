using UnityEngine;
using System.Collections;

[RequireComponent(typeof(EntityController))]
public class EntityInputAdapter : EntityBehaviour<GameEntity>
{

    // Update is called once per frame
    void Update()
    {
        var controller = GetComponent<EntityController>();
        controller.Movement = InputManager.Instance.Movement;
        controller.Jumped = InputManager.Instance.GetAction(InputManager.Instance.JumpAction);
        controller.ClimbSpeed = InputManager.Instance.GetAction(InputManager.Instance.ClimbAction) ? InputManager.Instance.Movement.y : 0;
        controller.SkillIndex = InputManager.Instance.GetSkillIndex();
    }
}
