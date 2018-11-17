redGlass = scene.entity("RedGlass");
player = scene.entity("Player");
conversation = {
    "${left}: ${right}你来了。",
    "${right}: 嗯，我来了。"
}
game.conversation(redGlass, player, conversation)
.Then(function()
    
end)
.Then(function()
    console.log("Complete");
end)