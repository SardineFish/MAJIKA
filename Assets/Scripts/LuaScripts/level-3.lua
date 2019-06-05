
function start()
    boss = scene.entity("Boss-3");
    player = scene.entity("Player");
    camera.follow(player);
    game.control(player);
end

function update(dt)

end

