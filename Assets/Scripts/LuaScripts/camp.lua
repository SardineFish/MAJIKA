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
    console.log(player);
end
function start()
    console.log("start");
    startCoroutine(moveCamera); 
end

function moveCamera()
    stopCoroutine(playerWalkCoroutine);
    coroutine.yield(waitForSeconds(1.5));
    camera.speed = 3;
    camera.acceleration = 3;
    camera.follow(twinTail);
    coroutine.yield(waitForSeconds(.5));
    camera.follow(yellowHair);
    coroutine.yield(waitForSeconds(2.5));
    camera.follow(player);
    coroutine.yield(waitForSeconds(2));
    game.control(player);
end

function playerWalk()
    while true do
        player.move(vec2(.3, 0));
        coroutine.yield(nil);
    end
end
