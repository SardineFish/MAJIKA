function start()
    startCoroutine(tutorial);
end

function tutorial()
    local player = scene.entity("Player");
    coroutine.yield(game.conversation({
        "这里是移动教学"
    }, { player }));

end
