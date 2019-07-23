SkillArcaneBall = 0;
SkillArcaneBlast = 1;
SkillArcaneJet = 2;
SkillTeleportIn = 3;
SkillTeleportOut = 4;

player = nil;

function active()
    player = scene.entity("Player")
    startCoroutine(idle)
end

function idle()
    repeat
        entity.skill(SkillArcaneBall, player)
        coroutine.yield(entity.wait("skill", _host))


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
        
        entity.skill(SkillArcaneJet, player.position.x - entity.position.x)
        coroutine.yield(entity.wait("skill", _host))
        
        entity.skill(SkillArcaneBlast, player.position.x - entity.position.x)
        coroutine.yield(entity.wait("skill", _host))


    until false
end