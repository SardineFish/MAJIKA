entity.startCoroutine(function() 
    while true do
        entity.move(vec2(-1,0));
        coroutine.yield(nil);
    end
end)