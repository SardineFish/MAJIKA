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

function start()
    entity.position = posA
    --fsm.start("UpLeft")   
    player = scene.entity("Player") 
    splashDrop = scene.object("Splash-Drop")
    startCoroutine(stage1UpLeft)
end

function update()
    if not droped and entity.position.y <= 4 then
        splashDrop.position = vec2(entity.position.x, splashDrop.position.y)
        droped = true
        scene.event("Stage")
    end
    if entity.HP <= 0 then
        camera.follow({entity})
    end
end

function changeState(func)
    startCoroutine(func)
end

actionCount = 0

function stage1UpLeft()
    console.log("upLeft")

    repeat 
        coroutine.yield(nil)
        entity.skill(SkillWaterImpact, Right)
    until false

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
        coroutine.yield(waitForSeconds(1))

        if entity.HP <= 0 then
            changeState(death)
            return
        end

        if actionCount >= 4 and entity.skill(SkillDive, Left) then
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
