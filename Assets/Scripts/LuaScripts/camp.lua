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
    camera.follow(twinTail);
    coroutine.yield(waitForSeconds(1));
    camera.follow(yellowHair);
    coroutine.yield(waitForSeconds(1.5));
    camera.follow(player);
    coroutine.yield(waitForSeconds(2));
    game.control(player);
end