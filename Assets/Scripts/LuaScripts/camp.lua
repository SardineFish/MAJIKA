local player;
local yellowHair;
local redGlass;
local twinTail;
function awake()
    player = scene.entity("Player");
    yellowHair = scene.entity("YellowHair");
    redGlass = scene.entity("RedGlass");
    twinTail = scene.entity("TwinTail");
end
function start()
    startCoroutine(moveCamera); 
end

function moveCamera()
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