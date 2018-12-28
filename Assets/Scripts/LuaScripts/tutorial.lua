local player;
local boss;
local gameEnd = false;
function awake()
    local prefab = resources.prefab("Player");
    boss = scene.spawn(resources.prefab("Boss-0"), "Boss", vec2(180, 3));
    player = scene.spawn(prefab, "Player", vec2(5, 2.2));
    camera.reset();
    camera.follow(player);
end

function start()
    boss.setActive(false);
    game.control(player);
    startCoroutine(tutorial);
    
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
    --coroutine.yield(player.wait("action", _host));
    --coroutine.yield(waitForSeconds(1));
    game.over();
end

function bossDead()
    game.control(nil);
    game.setTarget(nil);
    coroutine.yield(boss.wait("action", _host));
    game.pass();
end

function tutorial()
    coroutine.yield(waitForSeconds(0.7));
    game.tips("使用 A, S, D, W 移动", 3);
    repeat coroutine.yield(nil); 
    until player.position.x > 25;
    coroutine.yield(game.conversation({
        "血迹，看起来像是发生过战斗"
    },{player}));

    repeat coroutine.yield(nil); 
    until player.position.x > 43;
    game.tips("使用 [Space] 跳过障碍物", 2);

    repeat coroutine.yield(nil);
    until player.position.x > 70;
    coroutine.yield(game.conversation({
        "外面的天色预示着什么……"
    },{player}));

    repeat coroutine.yield(nil);
    until player.position.x > 134;
    
    boss.setActive(true);
    boss.restartScript();
    coroutine.yield(game.conversation({
        "安静的走廊里好像能听见什么……"
    },{player}));

    camera.follow(boss);
    coroutine.yield(waitForSeconds(6));
    game.setTarget(boss, "Boss");
    camera.follow(player);

end
