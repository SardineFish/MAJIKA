posA = vec2(24, 17);
posB = vec2(62, 17);
posC = vec2(43, 11);

SkillDash = 0;
SkillDive = 1;
SkillSliceScreen = 2;

Left = -1;
Right = 1;

function start()
    entity.position = posA
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
