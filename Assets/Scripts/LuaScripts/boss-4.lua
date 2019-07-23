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
    game.target(entity, "Boss");

    entity.skill(SkillTeleportIn, player.position.x - entity.position.x)
    coroutine.yield(entity.wait("skill", _host))
    local pos = player.position
    pos.x = pos.x - player.direction * 5
    if pos.y > 4 then
        pos.y = 4
    end
                console.log(pos)
    entity.position = pos
    entity.skill(SkillTeleportOut, player.position.x - entity.position.x)
    coroutine.yield(entity.wait("skill", _host))

    startCoroutine(battle);
end

function battle()
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
        elseif entity.skill(SkillArcaneJet, player) then
            coroutine.yield(wait("skill"))
        end

        startCoroutine(idle)
        return
    until false
end

function idle()
    local deltaX = player.position.x - entity.position.x
    local move = 0
    -- Determind move direction
    if math.abs(deltaX) > 18 then
        move = deltaX
    elseif math.abs(deltaX) < 8 then
        move = -deltaX
    elseif math.random() < 0.3 then
        move = sign(math.random() - 0.5) * deltaX
    end

    -- Perform moving & player skill detecting
    for t in timer(0.5 + math.random() * 0.5) do
        deltaX = player.position.x - entity.position.x

        if 
            (entity.position.y > 3
            or (player.state == "skill" and sign(-deltaX) == sign(player.direction)))
            and entity.skill(SkillTeleportIn, player)
        then
            local pos = player.position
            pos.x = pos.x - player.direction * 5
            if pos.y > 4 then
                pos.y = 4
            end
            --console.log(pos)
            coroutine.yield(wait("skill"))
            entity.position = pos
            entity.skill(SkillTeleportOut, player)
            coroutine.yield(wait("skill"))
            break
        end
        if move == 0 then
            entity.face(deltaX)
        else
            entity.move(vec2(sign(move), 0))
        end
        
        coroutine.yield(nil)
    end

    startCoroutine(battle)
end