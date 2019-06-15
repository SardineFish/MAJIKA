
function start()
    boss = scene.entity("Boss-3-Dragon");
    player = scene.entity("Player");
    camera.follow({player, boss});
    game.control(player);
    game.setTarget(boss, "Boss");
end

function update(dt)

end

