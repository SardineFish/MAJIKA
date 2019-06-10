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

states = {
    ["UpLeft"] = {
        name = "up left",
        skills = {
            {
                skill = SkillWindBlow,
                dir = Right,
                prob = 0.25,
            },
            {
                skill = SkillDash,
                dir = Right,
                prob = 0.25,
                transit = "UpRight",
            },
            {
                skill = SkillFeatherBarrier,
                dir = Right,
                prob = 0.25,
            },
            {
                skill = SkillDive,
                dir = Right,
                prob = 0.25,
                transit = "Center"
            }
        }
    },
    ["UpRight"] = {
        name = "up right",
        skills = {
            {
                skill = SkillWindBlow,
                dir = Left,
                prob = 0.25,
            },
            {
                skill = SkillDash,
                dir = Left,
                prob = 0.25,
                transit = "UpLeft"
            },
            {
                skill = SkillFeatherBarrier,
                dir = Left,
                prob = 0.25,
            },
            {
                skill = SkillDive,
                dir = Left,
                prob = 0.25,
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

function start()
    entity.position = posA
    fsm.start("UpLeft")    
    --startCoroutine(stage1UpLeft)
end

function changeState(func)
    startCoroutine(func)
end


function stage1UpLeft()
    coroutine.yield(nil)
    console.log("upLeft")
    if math.random() < .5 then
        if entity.skill(SkillDash, Right) then
            coroutine.yield(entity.wait("skill", _host))
            changeState(stage1UpRight)
        end
    else
        if entity.skill(SkillDive, Right) then
            coroutine.yield(entity.wait("skill", _host))
            changeState(stage2Center)
        end
    end
    console.log("upLeft end")
end
function stage1UpRight()
    coroutine.yield(nil)
    console.log("upRight")
    if math.random() < .5 then
        if entity.skill(SkillDash, Left) then
            coroutine.yield(entity.wait("skill", _host))
            changeState(stage1UpLeft)
        end
    else
        if entity.skill(SkillDive, Left) then
            coroutine.yield(entity.wait("skill", _host))
            changeState(stage2Center)
        end
    end
end
function stage2Center()
    coroutine.yield(nil)
    console.log("center")
    if entity.skill(SkillSliceScreen, Right) then
        coroutine.yield(entity.wait("skill", _host))
        entity.position = posA - (posC - posA)
        entity.skill(SkillDive, Right)
        coroutine.yield(entity.wait("skill", _host))
        changeState(stage1UpLeft)
    end
    console.log("center end")
end
