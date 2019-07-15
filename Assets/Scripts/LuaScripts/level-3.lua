boss = nil;
player = nil;

function start()
    resources.loadAll("Boss/Boss-3/");
    resources.loadAll("Player/");
    resources.loadAll("Texture/Map/Scene-3");
    boss = scene.entity("Boss-3-Bird");
    player = scene.entity("Player");
    camera.follow({player, boss});
    game.control(player);
    game.setTarget(boss, "Boss");
    scene.on("Stage", stage);
    game.ready();
end

function update(dt)
    if player.HP <= 0 then
        game.over()
    end
end

function stage()
    startCoroutine(function()
        camera.follow(nil)
        boss = scene.entity("Boss-3-Dragon")
        coroutine.yield(waitForSeconds(1.5))
        camera.follow({boss})
        coroutine.yield(waitForSeconds(6))
        game.setTarget(boss, "Boss")
        camera.follow({player, boss})

        repeat
            coroutine.yield(nil)
        until boss.HP <= 0
        
    end)
end