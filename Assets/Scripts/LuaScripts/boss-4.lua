SkillArcaneBall = 0;
SkillArcaneBlast = 1;
SkillArcaneJet = 2;
SkillTeleportIn = 3;
SkillTeleportOut = 4;

player = nil;
fullHP = 1000;
stage = 2;

function active()
    player = scene.entity("Player")
    startCoroutine(birth)
    entity.face(-1)
end

function birth()

    repeat 
        coroutine.yield(nil)
    until player.position.x >= 21

    game.control(nil)
    camera.follow({entity})
    
    coroutine.yield(wait(3))
    camera.follow({player, entity})
    game.control(player)

    entity.skill(SkillTeleportIn, player.position.x - entity.position.x)
    coroutine.yield(entity.wait("skill", _host))
    local pos = player.position
    pos.x = pos.x - player.direction * 5
    if pos.y > 4 then
        pos.y = 4
    end
    entity.position = pos
    entity.skill(SkillTeleportOut, player.position.x - entity.position.x)
    coroutine.yield(entity.wait("skill", _host))

    startCoroutine(idle);
end

function idle()
    repeat

        local deltaX = player.position.x - entity.position.x

        if entity.HP < fullHP * stage / 3 then
            stage = stage - 1
            entity.skill(SkillArcaneBlast, deltaX)
            coroutine.yield(wait("skill"))
        elseif player.state == "skill" and sign(-deltaX) == sign(player.direction) then
            if entity.skill(SkillTeleportIn, player) then
                local pos = player.position
                pos.x = pos.x - player.direction * 5
                if pos.y > 4 then
                    pos.y = 4
                end
                coroutine.yield(wait("skill"))
                entity.position = pos
                entity.skill(SkillTeleportOut, player)
                coroutine.yield(wait("skill"))
            end
        end

        if math.random() < 0.7 and entity.skill(SkillArcaneBall, player) then
            coroutine.yield(wait("skill"))
        elseif entity.skill(SkillArcaneBall, player) then
            coroutine.yield(wait("skill"))
        end

        -- Idle state of boss
        for t in timer(1.5) do
            deltaX = player.position.x - entity.position.x
            if player.state == "skill"
                and sign(-deltaX) == sign(player.direction)
                and entity.skill(SkillTeleportIn, player)
            then
                local pos = player.position
                pos.x = pos.x - player.direction * 5
                if pos.y > 4 then
                    pos.y = 4
                end
                coroutine.yield(wait("skill"))
                entity.position = pos
                entity.skill(SkillTeleportOut, player)
                coroutine.yield(wait("skill"))
                break
            end

            if math.abs(deltaX) > 18 then
                entity.move(vec2(sign(deltaX), 0))
            elseif math.abs(deltaX) < 8 then
                entity.move(vec2(-sign(deltaX), 0))
            else 
                entity.face(deltaX)
                entity.move(vec2(0, 0))
            end
            
            coroutine.yield(nil)
        end

        -- entity.skill(SkillArcaneBall, player)
        -- coroutine.yield(entity.wait("skill", _host))


        -- entity.skill(SkillTeleportIn, player.position.x - entity.position.x)
        -- coroutine.yield(entity.wait("skill", _host))
        -- local pos = player.position
        -- pos.x = pos.x - player.direction * 5
        -- if pos.y > 4 then
        --     pos.y = 4
        -- end
        -- entity.position = pos
        -- entity.skill(SkillTeleportOut, player.position.x - entity.position.x)
        -- coroutine.yield(entity.wait("skill", _host))
        
        -- entity.skill(SkillArcaneJet, player.position.x - entity.position.x)
        -- coroutine.yield(entity.wait("skill", _host))
        
        -- entity.skill(SkillArcaneBlast, player.position.x - entity.position.x)
        -- coroutine.yield(entity.wait("skill", _host))


    until false
end