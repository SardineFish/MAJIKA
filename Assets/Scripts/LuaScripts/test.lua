redGlass = scene.entity("RedGlass");
player = scene.entity("Player");
conversation1 = {
    "${left}: ${right}你来了。",
    "${right}: 嗯，我来了。"
}
conversation2 = {
    "${left}: Are You OK? ",
    "${right}: YEAH! ",
    "${left}: ......"
}

game.conversation(redGlass, player, conversation1)
.Then(function()
    local prefab = resources.prefab("Scarecrow");
    local enemy = scene.addEntity(prefab, "Enemy", vec2(25,3));
    enemy.onDead.add(function()
        game.conversation(redGlass,player,conversation2)
    end)
end)
