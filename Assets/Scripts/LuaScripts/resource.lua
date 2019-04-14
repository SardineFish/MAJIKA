function start()
    cloak = Item.find("Cloak")

    flameGem = Item.find("FlameGem")
    iceGem = Item.find("IceGem")
    airGem = Item.find("AirGem")
    arcaneGem = Item.find("ArcaneGem")

    flameJet = Item.find("FlameJet")
    airBoom = Item.find("AirBoom")
    arcaneShield = Item.find("ArcaneShield")
    iceSpear = Item.find("IceSpearx3")

    flameSlash = Item.find("FlameSlash")
    tornado = Item.find("Tornado")
    frozenSpike = Item.find("FrozenSpike")
    arcaneJet = Item.find("ArcaneJet")

    majikaCore = Item.find("MAJIKACore")

    flameJet.from(flameGem + flameGem + flameGem)
    airBoom.from(airGem + airGem + airGem)
    iceSpear.from(iceGem + iceGem + iceGem)
    arcaneShield.from(arcaneGem + arcaneGem + arcaneGem)

    flameSlash.from(flameJet + majikaCore)
    tornado.from(airBoom + majikaCore)
    frozenSpike.from(iceSpear + majikaCore)
    arcaneJet.from(arcaneShield + majikaCore)

end
