posA = vec2(24, 17);
posB = vec2(62, 17);
posC = vec2(43, 11);

SkillDash = 0;
SkillDive = 1;
SkillSliceScreen = 2;
SkillFeatherBarrier = 3;
SkillWindBlow = 4;

Left = -1;
Right = 1;

player = nil;

states = {
    ["UpLeft"] = {
        name = "up left",
        skills = {
            {
                skill = SkillDive,
                dir = Right,
                prob = 0.15,
                transit = "Center"
            },
            {
                skill = SkillDash,
                dir = Right,
                prob = 0.25,
                transit = "UpRight",
            },
            {
                skill = SkillWindBlow,
                dir = Right,
                prob = 0.25,
            },
            {
                skill = SkillFeatherBarrier,
                dir = Right,
                prob = 0.25,
            },
        }
    },
    ["UpRight"] = {
        name = "up right",
        skills = {
            {
                skill = SkillDash,
                dir = Left,
                prob = 0.25,
                transit = "UpLeft"
            },
            {
                skill = SkillWindBlow,
                dir = Left,
                prob = 0.25,
            },
            {
                skill = SkillFeatherBarrier,
                dir = Left,
                prob = 0.25,
            },
            {
                skill = SkillDive,
                dir = Left,
                prob = 0.15,
                transit = "Center",
            }
        }
    },
    ["Center"] = {
        name = "center",
        skills = {
            {
                skill = SkillSliceScreen,
                dir = Right,
                prob = 1,
                func = function()
                    entity.position = posA - (posC - posA)
                    entity.skill(SkillDive, Right)
                    coroutine.yield(entity.wait("skill", _host))
                end,
                transit = "UpLeft"
            }
        }
    }
}
fsm = SimpleStateMachine.new(states, 1)

function randomSkill(skills, dir)
    local totalWeight = 0
    for i, skill in ipairs(skills) do
        totalWeight = totalWeight + skill.weight
    end

    for i, skill in ipairs(skills) do
        if math.random() < skill.weight / totalWeight then
            local performed = entity.skill(skill.skill, dir)
            if performed then 
                return true 
            end
        end
        totalWeight = totalWeight - skill.weight
    end
    return false
end

function start()
    entity.position = posA
    --fsm.start("UpLeft")   
    player = scene.entity("Player") 
    startCoroutine(stage1UpLeft)
end

function changeState(func)
    startCoroutine(func)
end

actionCount = 0

function stage1UpLeft()
    console.log("upLeft")

    repeat
        coroutine.yield(nil)

        if actionCount >= 4 and entity.skill(SkillDive, Right) then
            coroutine.yield(entity.wait("skill", _host))
            changeState(stage2Center)
            return
        elseif 
            player.position.y > 12
            and math.random() < .5 
            and entity.skill(SkillWindBlow, Right) 
        then
            coroutine.yield(entity.wait("skill", _host))
            actionCount = actionCount + 1
        elseif math.random() < .5 and entity.skill(SkillDash, Right) then
            coroutine.yield(entity.wait("skill", _host))
            changeState(stage1UpRight)
            actionCount = actionCount + 1
            return
        elseif entity.skill(SkillFeatherBarrier, Right) then
            coroutine.yield(entity.wait("skill", _host))
        end
    until false
end

function stage1UpRight()
    console.log("upRight")

    repeat
        coroutine.yield(nil)

        if actionCount >= 4 and entity.skill(SkillDive, Left) then
            coroutine.yield(entity.wait("skill", _host))
            changeState(stage2Center)
            return
        elseif 
            player.position.y > 12
            and math.random() < .5 
            and entity.skill(SkillWindBlow, Left) 
        then
            coroutine.yield(entity.wait("skill", _host))
            actionCount = actionCount + 1
        elseif math.random() < .5 and entity.skill(SkillDash, Left) then
            coroutine.yield(entity.wait("skill", _host))
            changeState(stage1UpLeft)
            actionCount = actionCount + 1
            return
        elseif entity.skill(SkillFeatherBarrier, Left) then
            coroutine.yield(entity.wait("skill", _host))
        end
    until false
end
function stage2Center()
    coroutine.yield(nil)
    console.log("center")
    actionCount = 0
    if entity.skill(SkillSliceScreen, Right) then
        coroutine.yield(entity.wait("skill", _host))
        entity.position = posA - (posC - posA)
        entity.skill(SkillDive, Right)
        coroutine.yield(entity.wait("skill", _host))
        changeState(stage1UpLeft)
    end
    console.log("center end")
end
