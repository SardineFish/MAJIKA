local battleStarted = false;

function awake()
    player = scene.entity("Player");
    boss = scene.entity("Boss-1");

    camera.reset();
    camera.follow(player);
    game.control(player);
    startCoroutine(level);
end
function start()
end

function update(dt)
    if battleStarted then
        if(player.position.x > 27) then
            camera.follow({player, boss});
        else
            camera.follow(player);
        end
    end

end

function level()
    repeat coroutine.yield(nil); 
    until player.position.x > 27;
    camera.follow(boss);
    coroutine.yield(waitForSeconds(0.5));
    boss.setActive(true);
    coroutine.yield(waitForSeconds(1.5));
    camera.follow({player, boss});
    battleStarted = true;
end