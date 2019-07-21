local player;
local yellowHair;
local redGlass;
local twinTail;

local playerWalkCoroutine;

conversation2 = {
    "${left}: Are You OK? ",
    "${right}: YEAH! ",
    "${left}: ......"
}

function start()
    resources.loadAll("Player/");
    resources.loadAll("Texture/UI/");
    resources.loadAll("Texture/Map/Scene-0");

    player = scene.entity("Player");
    yellowHair = scene.entity("YellowHair");
    redGlass = scene.entity("RedGlass");
    twinTail = scene.entity("TwinTail");

    game.ready();

    
    game.tips("使用 ${movement} 移动", 30);

    yellowHair.on("OnInteract", function()
        --game.control(null)
        gui.skillPanel.show()
    end)

    redGlass.on("OnInteract", function()
        --game.conversation(conversation1, {player, redGlass})
        startCoroutine(function ()
            coroutine.yield(game.conversation({
                "${1}: <color=red>${conv1}",
                "${0}: ${conv2}",
                "${1}: 下一关？",
                "${0}: 不 要 停 下 来 "
            },{player, redGlass}, true));
            game.loadLevel("Level-2");
        
        end)
    end)

    twinTail.on("OnInteract", function()
        startCoroutine(function ()
            coroutine.yield(game.conversation({
                "${1}: Emmmm?",
                "${0}: ¿",
                "${1}: 这边请。",
                "${0}: ……"
            },{player, twinTail}, true));
            game.loadLevel("Tutorial");
        
        end)
    end)

    --playerWalkCoroutine = startCoroutine(playerWalk);
    camera.reset();
    camera.follow(player);
    game.control(player);
    --gui.skillPanel.hide();
end

function moveCamera()
    coroutine.yield(waitForSeconds(1.5));
    stopCoroutine(playerWalkCoroutine);
    coroutine.yield(waitForSeconds(1));
    camera.speed = 3;
    camera.acceleration = 3;
    camera.follow(twinTail);
    coroutine.yield(waitForSeconds(.5));
    camera.follow(yellowHair);
    coroutine.yield(waitForSeconds(4));
    camera.follow(player);
    coroutine.yield(waitForSeconds(3));
    game.control(player);
    game.loadScene("Scenes/Credit");
end

function playerWalk()
    while true do
        player.move(vec2(.3, 0));
        coroutine.yield(nil);
    end
end
