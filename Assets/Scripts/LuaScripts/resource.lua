function start()
    cloak = Item.find("Cloak/Cloak")
    stone = Item.find("FlameStone/FlameStone")
    
    cloak.from(cloak + stone)
    stone.from(stone + stone)
end
