local player;
local yellowHair;
local redGlass;
local twinTail;

local playerWalkCoroutine;

function awake()
    player = scene.entity("Player");
    boss = scene.entity("Boss-1");

    camera.reset();
    camera.follow(player);
    game.control(player);
end
function start()
end

function update(dt)
    console.log("update");
    if(player.position.x > 27) then
        console.log("Folow both");
        camera.follow({player, boss});
    else
        console.log("Folow player");
        camera.follow(player);
    end

end