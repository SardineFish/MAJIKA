posA = vec2(24, 17);
posB = vec2(62, 17);
posC = vec2(43, 11);

SkillDash = 0;
SkillDive = 1;
SkillSliceScreen = 2;
SkillFeatherBarrier = 3;
SkillWindBlow = 4;
SkillWaterImpact = 5;

Left = -1;
Right = 1;

player = nil;
splashDrop = nil;
droped = false;

function awake()
    entity.position = vec2(43, 0)
    player = scene.entity("Player") 
    splashDrop = scene.object("Splash-Drop")
end

function active()
    console.log("dragon start")
    --fsm.start("UpLeft")   
    startCoroutine(birth)
end

function update()
end

function changeState(func)
    startCoroutine(func)
end

actionCount = 0

function birth()
    repeat
        coroutine.yield(nil)
    until entity.state == "Idle"

    changeState(stage2Center)
end

function stage1UpLeft()
    console.log("upLeft")

    repeat
        coroutine.yield(waitForSeconds(1))

        if entity.HP <= 0 then
            changeState(death)
            return
        end
        

        if actionCount >= 4 and entity.skill(SkillDive, Right) then
            coroutine.yield(entity.wait("skill", _host))
            changeState(stage2Center)
            return
        elseif 
            player.position.y > 15
            and math.random() < .5 
            and entity.skill(SkillWindBlow, Right) 
        then
            coroutine.yield(entity.wait("skill", _host))
            actionCount = actionCount + 1
        elseif math.random() < .3 and entity.skill(SkillDash, Right) then
            coroutine.yield(entity.wait("skill", _host))
            changeState(stage1UpRight)
            actionCount = actionCount + 1
            return
        elseif math.random() < .5 and entity.skill(SkillFeatherBarrier, Right) then
            coroutine.yield(entity.wait("skill", _host))
            actionCount = actionCount + 1
        else
            entity.skill(SkillWaterImpact, Right)
            actionCount = actionCount + 1
        end
        
    until false
end

function stage1UpRight()
    console.log("upRight")

    repeat
        coroutine.yield(waitForSeconds(1))

        if entity.HP <= 0 then
            changeState(death)
            return
        end

        if actionCount > 4 and entity.skill(SkillDive, Left) then
            coroutine.yield(entity.wait("skill", _host))
            changeState(stage2Center)
            return
        elseif 
            player.position.y > 15
            and math.random() < .5 
            and entity.skill(SkillWindBlow, Left) 
        then
            coroutine.yield(entity.wait("skill", _host))
            actionCount = actionCount + 1
        elseif math.random() < .3 and entity.skill(SkillDash, Left) then
            coroutine.yield(entity.wait("skill", _host))
            changeState(stage1UpLeft)
            actionCount = actionCount + 1
            return
        elseif math.random() < .5 and entity.skill(SkillFeatherBarrier, Left) then
            coroutine.yield(entity.wait("skill", _host))
            actionCount = actionCount + 1
        else
            entity.skill(SkillWaterImpact, Left)
            actionCount = actionCount + 1
        end
    until false
end
function stage2Center()
        coroutine.yield(waitForSeconds(1))

    if entity.HP <= 0 then
        changeState(death)
        return
    end
    
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

function death()
    coroutine.yield(entity.wait("animation", _host))
    entity.destroy()
end
