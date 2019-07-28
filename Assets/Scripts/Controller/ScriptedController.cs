using UnityEngine;
using System.Collections;

public class ScriptedController : ControllerPlugin
{
    public bool Continuous;
    Vector2 movement = Vector2.zero;
    float faceDirection;
    int skillIndex = -1;
    bool jumped = false;
    bool climbed = false;
    GameEntity skillTarget = null;

    public override Vector2 Movement => movement;

    public override int SkillIndex => skillIndex;

    public override bool Jumped => jumped;

    public override bool Climbed => climbed;

    public override float FaceDirection => faceDirection;

    public override GameEntity SkillTarget => skillTarget;

    public void Move(Vector2 movement)
    {
        this.movement = movement;
        Face(movement.x);
    }
    public void Jump() => jumped = true;
    public void Climb(float speed)
    {
        movement.y = speed;
        climbed = speed != 0;
    }
    public bool Skill(int idx) => Skill(idx, 0);
    public bool Skill(int idx, float dir)
    {
        skillIndex = idx;
        Face(dir);
        var result = GetComponent<EntityController>().Skill();
        skillIndex = -1;
        return result;
    }
    public bool Skill(int idx, GameEntity target)
    {
        skillIndex = idx;
        skillTarget = target;
        Face(target.transform.position.x - transform.position.x);
        var result = GetComponent<EntityController>().Skill();
        skillIndex = -1;
        return result;
    }
    public void Face(float dir)
    {
        if (dir == 0)
            return;
        faceDirection = MathUtility.SignInt(dir);
    }
}
