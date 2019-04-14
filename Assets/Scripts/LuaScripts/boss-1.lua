local player;
local yellowHair;
local redGlass;
local twinTail;

local playerWalkCoroutine;

function awake()
    player = scene.entity("Player");

    camera.reset();
    camera.follow(player);
    game.control(player);
end
function start()
end