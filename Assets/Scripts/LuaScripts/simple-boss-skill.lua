
--[[

SimpleStateMachine.new(states, sleepTime)
function start(stateName)
function stop()
function transit(stateName)
    
]]--

SimpleStateMachine = {};
SimpleStateMachine.mt = {};
function SimpleStateMachine.new(states, sleepTime)
    local fsm = {};
    setmetatable(fsm, SimpleStateMachine.mt);
    
    local current = nil
    local running = false

    if sleepTime == nil then sleepTime = 0.1 end

    fsm.states = states
    fsm.sleepTime = sleepTime

    fsm.transit = function (name)
        if states[name] ~= nil then
            current = states[name]
            console.log("-> " .. current.name)
        end
    end

    fsm.start = function (name)
        fsm.transit(name)
        running = true;
        startCoroutine(fsm.coroutine);
    end

    fsm.coroutine = function ()
        repeat
            coroutine.yield(waitForSeconds(sleepTime))
            if current ~= nil then
                local sum = 1
                local performed = false
                for i, skill in ipairs(current.skills) do
                    local prob = skill.prob
                    local dir = skill.dir
                    if prob == nil then prob = 1 / #current.skills end
                    if dir == nil then dir = 1 end
                    if math.random() < prob / sum then
                        performed = entity.skill(skill.skill, dir)
                    end

                    if performed then 
                        coroutine.yield(entity.wait("skill", _host))
                        if skill.func ~= nil then
                            coroutine.yield(startCoroutine(skill.func))
                        end
                        if skill.transit ~= nil then
                            fsm.transit(skill.transit)
                        end
                        break 
                    end
                end
            end
        until running == false
    end

    return fsm
end