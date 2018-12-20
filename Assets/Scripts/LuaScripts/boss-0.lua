AIDuration = 0.2;
VisualRange = 24;

local player;
local lastAITime = 0;
function start()
    console.log(vec2(4,6)-vec2(2,3));
    player = scene.entity("Player");
    startCoroutine(bossAI);
end

function update(dt)
end

function bossAI()
    local co = startCoroutine(wander);
    local currentState = wander;
    function changeState(state)
        if(state ~= currentState) then
            stopCoroutine(co);
            co = startCoroutine(state);
            currentState = state;
        end
    end
    
    while true do
        coroutine.yield(waitForSeconds(AIDuration));

        local dpos = player.position - entity.position;
        if(math.abs(dpos.x) <= VisualRange) then
            changeState(chase);
        end

    end
end

function wander()
    local randomDuration = 2;
    local randomJitter = 1;
    local dir;
    local nextRandomTime;

    function next()
        dir = math.random(-1, 1);
        nextRandomTime = (math.random() * 2 - 1) * randomJitter + randomDuration + Time.time;
    end
    next();
    while true do
        entity.move(vec2(dir*0.5,0));
        coroutine.yield(nil);

        if(Time.time > nextRandomTime) then
            next();
        end
    end
end

function chase()
    local dpos = player.position - entity.position;
    while true do
        dpos = player.position - entity.position;
        entity.move(vec2(sign(dpos.x), 0));
        coroutine.yield(nil);
    end
end

function attack()
    local dpos = player.position - entity.position;
end

function sign(x)
    if(x > 0) then return 1 end
    if(x < 0) then return -1 end
    return 0;
end