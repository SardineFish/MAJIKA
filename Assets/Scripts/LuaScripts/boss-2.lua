Interval = 1.5;

local player
local lastAITime = 0

function start()
    entity.face(-1)
end

function active()
    player = scene.entity("Player")
    startCoroutine(birth)
end

function birth()
    repeat
        coroutine.yield(nil)
    until entity.state == "idle"

    startCoroutine(bossIdle)
end

function bossIdle()
    while player.position.x <= 27 do
        coroutine.yield(waitForSeconds(Interval))
    end
    startCoroutine(bossAttack)
end

function bossAttack()
    while player.position.x > 27 do
        local skill = math.floor(math.random() * 4)
        entity.skill(skill, player)
        coroutine.yield(entity.wait("skill", _host))
        coroutine.yield(waitForSeconds(Interval))
    end
    startCoroutine(bossIdle)
end