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
enemyCount = 3;

function entityDie( entity )
	enemyCount = enemyCount - 1;
    if enemyCount <= 0 then
        timeout(spawnEnemy, 1000);
	end
end

function spawnEnemy()
    enemyCount = 3;
    local prefab = resources.prefab("Scarecrow");
    scene.spawn(prefab, "Enemy", vec2(24,7)).onDead.add(entityDie);
    scene.spawn(prefab, "Enemy", vec2(26,5)).onDead.add(entityDie);
    scene.spawn(prefab, "Enemy", vec2(28,6)).onDead.add(entityDie);
end

spawnEnemy();