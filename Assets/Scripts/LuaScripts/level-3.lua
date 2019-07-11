
function start()
    boss = scene.entity("Boss-3-Dragon");
    player = scene.entity("Player");
    camera.follow({player, boss});
    game.control(player);
    game.setTarget(boss, "Boss");
    scene.on("Stage", stage);
end

function update(dt)

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
    end)
end