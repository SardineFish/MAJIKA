AIDuration = 0.2
VisualRange = 24

local player
local lastAITime = 0
function start()
    player = scene.entity("Player")
    --startCoroutine(chase)
    startCoroutine(bossAI)
end

function update(dt)
end

function bossAI()
    repeat coroutine.yield(nil);
    until player.position.x > 134;
    
    local co = startCoroutine(wander)
    local currentState = wander
    function changeState(state)
        if (state ~= currentState) then
            stopCoroutine(co)
            co = startCoroutine(state)
            currentState = state
        end
    end

    while true do
        coroutine.yield(waitForSeconds(AIDuration))

        local dpos = player.position - entity.position
        if (math.abs(dpos.x) <= VisualRange) then
            changeState(chase)
        end
    end
end

function wander()
    local randomDuration = 2
    local randomJitter = 1

    while true do
        local time = (math.random() * 2 - 1) * randomJitter + randomDuration
        local dir = math.random(-1, 1)

        for t in utility.timer(time) do
            entity.move(vec2(dir * 0.5, 0))
            coroutine.yield(nil)
        end
    end
end

function chase()
    local skillGap = 0.8
    local dpos = player.position - entity.position
    entity.move(vec2(sign(dpos.x), 0))
    while true do
        coroutine.yield(nil)
        dpos = player.position - entity.position
        local dx = math.abs(dpos.x)
        local skilled = false

        local threat = detectBullet();
        if(threat) then
            skilled = entity.skill(4, threat.position.x - entity.position.x);
        end
        
        if(dx<=5) then
            skilled = entity.skill(2, dpos.x) or entity.skill(3, dpos.x);
        elseif dx<=13 then
            skilled = entity.skill(0, dpos.x) or entity.skill(1, dpos.x);
        end

        if skilled then
            coroutine.yield(entity.wait("skill", _host))
            for t in utility.timer(skillGap) do
                dpos = player.position - entity.position
                if (math.abs(dpos.x) > 3) then
                    entity.move(vec2(sign(dpos.x), 0))
                end
                coroutine.yield(nil)
            end
        end
        entity.move(vec2(sign(dpos.x), 0))
    end
end

function detectBullet()
    local threat = entity.detectThreat();
    for k in pairs(threat) do
        local t = threat[k];
        if t.typeName == "bullet" then
            local dir =  entity.position.x - t.position.x;
            if(sign(t.velocity.x) == sign(dir) and entity.position.y <= t.position.y and t.position.y <= (entity.position.y + 3)) then
                return t;
            end
        end
    end
    return nil;
end

function attack()
end

function sign(x)
    if (x > 0) then
        return 1
    end
    if (x < 0) then
        return -1
    end
    return 0
end
