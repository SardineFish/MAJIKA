function start()
    startCoroutine(tutorial);
end

function tutorial()
    local player = scene.entity("Player");
    coroutine.yield(game.tips("使用 A, S, D, W 移动", 5));

end
