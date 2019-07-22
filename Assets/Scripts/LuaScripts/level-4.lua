player = nil
boss = nil

function start()
    resources.loadAll("Boss/Boss-4/")
    resources.loadAll("Player/")
    resources.loadAll("Texture/UI/")
    resources.loadAll("Texture/Map/Level-4")

    player = scene.entity("Player")
    boss = scene.entity("Boss-4")

    game.control(boss)
    camera.follow({player})

    game.ready();
end

function update(dt)
end