function start()
    cloak = Item.find("Cloak")

    flameGem = Item.find("FlameGem")
    iceGem = Item.find("IceGem")
    airGem = Item.find("AirGem")
    arcaneGem = Item.find("ArcaneGem")

    flameJet = Item.find("FlameJet")
    airBoom = Item.find("AirBoom")
    arcaneShield = Item.find("ArcaneShield")
    iceSpear = Item.find("IceSpear")

    flameJet.from(flameGem + flameGem + flameGem)
    airBoom.from(airGem + airGem + airGem)
    iceSpear.from(iceGem + iceGem + iceGem)
    arcaneShield.from(arcaneGem + arcaneGem + arcaneGem)

end
