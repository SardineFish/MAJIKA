local player;
local yellowHair;
local redGlass;
local twinTail;

local playerWalkCoroutine;

function awake()
    player = scene.entity("Player");
    yellowHair = scene.entity("YellowHair");
    redGlass = scene.entity("RedGlass");
    twinTail = scene.entity("TwinTail");
    playerWalkCoroutine = startCoroutine(playerWalk);
    camera.reset();
    camera.follow(player);
end
function start()
    startCoroutine(moveCamera); 
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
    camera.speed = 15;
    camera.acceleration = 35;
end

function playerWalk()
    while true do
        player.move(vec2(.3, 0));
        coroutine.yield(nil);
    end
end
