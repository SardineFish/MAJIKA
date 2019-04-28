local player;
local yellowHair;
local redGlass;
local twinTail;

local playerWalkCoroutine;

function awake()
    player = scene.entity("Player");
    boss = scene.entity("Boss-1");

    camera.reset();
    camera.follow(boss);
    game.control(boss);
end
function start()
end