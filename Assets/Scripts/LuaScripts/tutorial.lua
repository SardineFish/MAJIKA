local player;
local boss;
local gameEnd = false;

function start()
    resources.loadAll("Boss/Boss-0/");
    resources.loadAll("Player/");
    resources.loadAll("Texture/UI/");
    resources.loadAll("Fonts/")
    resources.loadAll("Texture/Map/Scene-0");

    local prefab = resources.prefab("Player");
    player = scene.spawn(prefab, "Player", vec2(5, 2.2));
    boss = scene.spawn(resources.prefab("Boss-0"), "Boss", vec2(180, 3));
    --boss.setActive(true);
    camera.reset();
    camera.follow(player);

    boss.setActive(false);
    startCoroutine(tutorial);
    game.control(player);

    game.ready();
end

function update()
    if gameEnd then
        return;
    end
    if player.HP <= 0 then
        gameEnd = true;
        startCoroutine(playerDead);
        return;
    end
    if boss and boss.HP <= 0 then
        gameEnd = true;
        startCoroutine(bossDead);
        return;
    end
end

function playerDead()
    game.control(nil);
    game.setTarget(nil);
    game.exitAudio();
    --coroutine.yield(player.wait("action", _host));
    --coroutine.yield(waitForSeconds(1));
    game.over();
end

function bossDead()
    game.control(nil);
    game.setTarget(nil);
    game.exitAudio();
    coroutine.yield(boss.wait("action", _host));
    game.playAudio(resources.audio("Win"), 0.25);
    game.pass();
end

function tutorial()
    coroutine.yield(waitForSeconds(0.7));
    game.tips("使用 A, S, D, W 移动", 3);
    repeat coroutine.yield(nil); 
    until player.position.x > 25;
    coroutine.yield(game.conversation({
        "血迹，看起来像是发生过战斗"
    },{player}, true));

    repeat coroutine.yield(nil); 
    until player.position.x > 43;
    game.tips("使用 [Space] 跳过障碍物", 2);

    repeat coroutine.yield(nil);
    until player.position.x > 70;
    coroutine.yield(game.conversation({
        "外面的天色预示着什么……"
    },{player}, true));

    repeat coroutine.yield(nil);
    until player.position.x > 134;
    
    boss.setActive(true);
    coroutine.yield(game.conversation({
        "安静的走廊里好像能听见什么……"
    },{player}, true));

    camera.follow(boss);
    coroutine.yield(waitForSeconds(4));
    game.setTarget(boss, "Boss");
    game.playAudio(resources.audio("Boss"), 0.25, 1, true);
    camera.follow(player);

end
