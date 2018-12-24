local player;
function start()
    local prefab = resources.prefab("Player");
    player = scene.spawn(prefab, "Player", vec2(5, 5));
    game.control(player);
    camera.follow(player);
    startCoroutine(tutorial);
end

function tutorial()
    coroutine.yield(game.tips("使用 A, S, D, W 移动", 5));

end
