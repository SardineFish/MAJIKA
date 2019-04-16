using UnityEngine;
using System.Collections;

public class EntityInputPlugin : ControllerPlugin
{
    public override void OnUpdate(EntityController controller)
    {
        controller.Movement = InputManager.Instance.GetInputValue<Vector2>(InputManager.Instance.MovementAction);
        controller.Jumped = InputManager.Instance.GetAction(InputManager.Instance.JumpAction);
        controller.Climbed = InputManager.Instance.GetAction(InputManager.Instance.ClimbAction);
        controller.SkillIndex = InputManager.Instance.GetSkillIndex();
    }
}
