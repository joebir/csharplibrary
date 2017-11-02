using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _0._14_NewVegasCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creates an array of all the perks to check.
            string[] fullPerkArray = {"Bloody Mess","Demolition Expert Rank 1","Demolition Expert Rank 2","Demolition Expert Rank 3","The Professional","Cowboy","Finesse","Better Criticals","Ninja",
                "Laser Commander","Slayer","Lord Death Rank 1","Lord Death Rank 2","Lord Death Rank 3","Melee Hacker Rank 1","Melee Hacker Rank 2","Set Lasers for Fun Rank 1",
                "Set Lasers for Fun Rank 2","Light Touch","Elijah's Ramblings","Grunt","Ain't Like That Now","Just Lucky I'm Alive","Thought You Died","Lonesome Road","Built to Destroy","Fast Shot",
                "Heavy Handed"};

            //Creates dictionaries of all of FNV's weapons
            Dictionary<string, Gun> guns = new Dictionary<string, Gun>();
            Gun mag357 = new Gun(".357 Magnum revolver", 26, 1, 26, 1.8, 0.6 * 6, 6);
            guns.Add(mag357.Name, mag357);
            Gun lucky = new Gun("Lucky", 30, 2.5, 30, 2.8, 0.7 * 6, 6);
            guns.Add(lucky.Name, lucky);
            Gun mag44 = new Gun(".44 Magnum revolver", 36, 1, 36, 1.9, 3, 6);
            guns.Add(mag44.Name, mag44);
            Gun mystMag = new Gun("Mysterious Magnum", 42, 1, 42, 2.4, 3, 6);
            guns.Add(mystMag.Name, mystMag);
            Gun pist45 = new Gun(".45 Auto pistol", 29, 1, 29, 2.8, 1.7, 7);
            guns.Add(pist45.Name, pist45);
            Gun aLSD = new Gun("A Light Shining in Darkness", 33, 2, 33, 4.4, 1.7, 6);
            guns.Add(aLSD.Name, aLSD);
            Gun decker = new Gun("5.56mm pistol (GRA)", 28, 2, 28, 2.8, 2.5, 5);
            guns.Add(decker.Name, decker);
            Gun thatGun = new Gun("That Gun", 30, 2.5, 30, 3, 2.5, 5);
            guns.Add(thatGun.Name, thatGun);
            Gun pist9mm = new Gun("9mm pistol", 16, 1, 16, 3.1, 1.7, 13);
            guns.Add(pist9mm.Name, pist9mm);
            Gun maria = new Gun("Maria", 20, 2, 20, 3.8, 1.7, 13);
            guns.Add(maria.Name, maria);
            Gun pist10mm = new Gun("10mm pistol", 22, 1, 22, 2.8, 1.3, 12);
            guns.Add(pist10mm.Name, pist10mm);
            Gun weathered10mm = new Gun("Weathered 10mm pistol", 24, 1, 24, 2.8, 1.3, 12);
            guns.Add(weathered10mm.Name, weathered10mm);
            Gun pist127 = new Gun("12.7mm pistol", 40, 1, 40, 2.8, 1.7, 7);
            guns.Add(pist127.Name, pist127);
            Gun devil = new Gun("Li'l Devil", 45, 2, 45, 3.3, 1.7, 7);
            guns.Add(devil.Name, devil);
            Gun huntRevolver = new Gun("Hunting revolver", 58, 1, 58, 1.5, 3, 5);
            guns.Add(huntRevolver.Name, huntRevolver);
            Gun huntRevGRA = new Gun("Hunting revolver (GRA)", 58, 1, 58, 1.5, 3, 5);
            guns.Add(huntRevGRA.Name, huntRevGRA);
            Gun sequoia = new Gun("Ranger Sequoia", 62, 1.5, 52, 1.7, 3, 5);
            guns.Add(sequoia.Name, sequoia);
            Gun policePist = new Gun("Police pistol", 30, 1, 30, 2, 3, 6);
            guns.Add(policePist.Name, policePist);
            Gun pist22 = new Gun("Silenced .22 pistol", 9, 3, 18, 3.5, 1.7, 16);
            guns.Add(pist22.Name, pist22);
            Gun amr = new Gun("Anti-materiel rifle", 110, 1, 110, 0.4, 2.5, 8);
            guns.Add(amr.Name, amr);
            Gun amrGRA = new Gun("Anti-materiel rifle (GRA)", 110, 1, 110, 0.4, 2.5, 8);
            guns.Add(amrGRA.Name, amrGRA);
            Gun autoCarbine = new Gun("Assault carbine", 13, 0.06, 13, 12, 2, 24);
            guns.Add(autoCarbine.Name, autoCarbine);
            Gun autoCarbineGRA = new Gun("Assault carbine (GRA", 13, 0.06, 13, 12, 2, 24);
            guns.Add(autoCarbineGRA.Name, autoCarbineGRA);
            Gun autoRifle = new Gun("Automatic rifle", 40, 0.18, 40, 6, 3, 20);
            guns.Add(autoRifle.Name, autoRifle);
            Gun batRifle = new Gun("Battle Rifle (GRA)", 48, 1, 48, 1.9, 1.9, 8);
            guns.Add(batRifle.Name, batRifle);
            Gun thisMachine = new Gun("This Machine", 55, 1, 55, 2.1, 1.9, 8);
            guns.Add(thisMachine.Name, thisMachine);
            Gun bb = new Gun("BB gun", 4, 1, 4, 1.5, 3.3, 100);
            guns.Add(bb.Name, bb);
            Gun bbUnique = new Gun("Abilene Kid LE BB gun", 4, 1.5, 70, 1.5, 3.3, 100);
            guns.Add(bbUnique.Name, bbUnique);
            Gun brushGun = new Gun("Brush Gun", 75, 1, 75, 1.2, 0.5 * 6, 6);
            guns.Add(brushGun.Name, brushGun);
            Gun medicine = new Gun("Medicine Stick", 78, 1, 78, 1.4, 0.5 * 8, 8);
            guns.Add(medicine.Name, medicine);
            Gun cowboyRep = new Gun("Cowboy Repeater", 32, 1.25, 32, 1.7, 0.5 * 7, 7);
            guns.Add(cowboyRep.Name, cowboyRep);
            Gun llc = new Gun("La Longue Carabine", 35, 1.5, 35, 2.2, 3.3, 11);
            guns.Add(llc.Name, llc);
            Gun huntingRifle = new Gun("Hunting rifle", 52, 2, 52, 0.9, 2, 5);
            guns.Add(huntingRifle.Name, huntingRifle);
            Gun paciencia = new Gun("Paciencia", 55, 2, 110, 1.2, 2, 3);
            guns.Add(paciencia.Name, paciencia);
            Gun lmg = new Gun("Light machine gun", 21, 0.06, 21, 12, 2.2, 90);
            guns.Add(lmg.Name, lmg);
            Gun bozar = new Gun("Bozar", 19, 0.05, 19, 15, 2.2, 30);
            guns.Add(bozar.Name, bozar);
            Gun markCarbine = new Gun("Marksman carbine", 24, 1, 24, 5.7, 2, 20);
            guns.Add(markCarbine.Name, markCarbine);
            Gun allamerican = new Gun("All-American", 26, 1, 26, 6, 2, 24);
            guns.Add(allamerican.Name, allamerican);
            Gun service = new Gun("Service rifle", 18, 1, 18, 4.2, 2, 20);
            guns.Add(service.Name, service);
            Gun survRifle = new Gun("Survivalist's rifle", 48, 1, 48, 3.9, 2, 10);
            guns.Add(survRifle.Name, survRifle);
            Gun sniper = new Gun("Sniper rifle", 45, 2, 45, 1.9, 3, 5);
            guns.Add(sniper.Name, sniper);
            Gun cosSniper = new Gun("Christine's CoS silencer rifle", 62, 2.5, 62, 1.6, 3, 5);
            guns.Add(cosSniper.Name, cosSniper);
            Gun gobiSniper = new Gun("Gobi Campaign scout rifle", 48, 2, 80, 2.1, 3, 6);
            guns.Add(gobiSniper.Name, gobiSniper);
            Gun trailCarbine = new Gun("Trail carbine", 48, 1, 48, 1.5, 0.5 * 8, 8);
            guns.Add(trailCarbine.Name, trailCarbine);
            Gun varmint = new Gun("Varmint rifle", 18, 1, 18, 1.2, 2.2, 5);
            guns.Add(varmint.Name, varmint);
            Gun ratslayer = new Gun("Ratslayer", 23, 5, 23, 1.3, 2.2, 8);
            guns.Add(ratslayer.Name, ratslayer);
            Gun smg45 = new Gun(".45 Auto submachine gun", 26, 0.06, 26, 11, 2.2, 30);
            guns.Add(smg45.Name, smg45);
            Gun smg9 = new Gun("9mm submachine gun", 14, 0.06, 14, 11, 2.7, 30);
            guns.Add(smg9.Name, smg9);
            Gun vance = new Gun("Vance's 9mm submachine gun", 17, 0.05, 17, 13, 2.7, 60);
            guns.Add(vance.Name,vance);
            Gun smg10 = new Gun("10mm submachine gun", 19, 0.08, 19, 9, 2.7, 30);
            guns.Add(smg10.Name, smg10);
            Gun sleepytyme = new Gun("Sleepytyme (GRA)", 22, 0.1, 22, 10, 2.7, 40);
            guns.Add(sleepytyme.Name, sleepytyme);
            Gun smg127 = new Gun("12.7mm submachine gun", 36, 0.08, 36, 9, 2, 21);
            guns.Add(smg127.Name, smg127);
            Gun smg127GRA = new Gun("12.7mm submachine gun (GRA)", 36, 0.08, 36, 9, 2, 21);
            guns.Add(smg127GRA.Name, smg127GRA);
            Gun nailgun = new Gun("H&H Tools nail gun", 9, 0.12, 9, 14, 2.7, 90);
            guns.Add(nailgun.Name, nailgun);
            Gun smg22 = new Gun("Silenced .22 submachine gun", 10, 0.23, 20, 11, 2.3, 180);
            guns.Add(smg22.Name, smg22);
            Gun caravan = new Gun("Caravan shotgun", 45, 1, 6 * 7, 3.2, 1.5, 2);
            guns.Add(caravan.Name, caravan);
            Gun sturdyCaravan = new Gun("Sturdy caravan shotgun", 50, 1, 7 * 7, 3.2, 1.5, 2);
            guns.Add(sturdyCaravan.Name, sturdyCaravan);
            Gun huntingShot = new Gun("Hunting shotgun", 70, 1, 10 * 7, 1.7, 0.5 * 5, 5);
            guns.Add(huntingShot.Name, huntingShot);
            Gun dinner = new Gun("Dinner Bell", 75, 1, 11 * 7, 1.7, 0.5 * 5, 5);
            guns.Add(dinner.Name, dinner);
            Gun leverShot = new Gun("Lever-action shotgun", 48, 1, 7 * 7, 1.8, 0.5 * 5, 5);
            guns.Add(leverShot.Name, leverShot);
            Gun riotShot = new Gun("Riot shotgun", 67, 1, 10 * 7, 4, 2.2, 12);
            guns.Add(riotShot.Name, riotShot);
            Gun sawedShot = new Gun("Sawed-off shotgun", 100, 1, 7 * 14, 2.3, 3.1, 1);
            guns.Add(sawedShot.Name, sawedShot);
            Gun boomerShot = new Gun("Big Boomer", 120, 1, 9 * 14, 2.6, 3.1, 1);
            guns.Add(boomerShot.Name, boomerShot);
            Gun singleShot = new Gun("Single shotgun", 50, 1, 7 & 7, 2.6, 2, 1);
            guns.Add(singleShot.Name, singleShot);
            Gun cyberdog = new Gun("K900 cyberdog gun", 26, 0.06, 13, 7, 4, 50);
            guns.Add(cyberdog.Name, cyberdog);
            Gun fido = new Gun("FIDO", 36, 0.06, 18, 7, 4, 50);
            guns.Add(fido.Name, fido);
            Gun minigun = new Gun("Minigun", 12, 0.02, 12, 28, 4, 240);
            guns.Add(minigun.Name, minigun);
            Gun avenger = new Gun("CZ57 Avenger", 13, 0.01, 13, 30, 4, 120);
            guns.Add(avenger.Name, avenger);
            Gun smmg = new Gun("Shoulder mounted machine gun", 30, 0, 20, 7, 2.8, 60);
            guns.Add(smmg.Name, smmg);

            Dictionary<string, Energy> energy = new Dictionary<string, Energy>();
            Energy alien = new Energy("Alien blaster", 75, 100, 50, 1.8, 2.3, 10);
            energy.Add(alien.Name, alien);
            Energy euclid = new Energy("Euclid's C-Finder", 150, 50, 0, 0.2, 2.3, 1);
            energy.Add(euclid.Name, euclid);
            Energy flare = new Energy("Flare gun", 10, 1.5, 1.8, 1.8, 2.3, 1);
            energy.Add(flare.Name, flare);
            Energy lasPist = new Energy("Laser pistol", 12, 1.5, 12, 3.8, 3, 30);
            energy.Add(lasPist.Name, lasPist);
            Energy lasPistGRA = new Energy("Laser pistol (GRA)", 12, 1.5, 12, 3.8, 3, 30);
            energy.Add(lasPistGRA.Name, lasPistGRA);
            Energy compliance = new Energy("Compliance Regulator", 8, 1.5, 12, 3.8, 3, 30);
            energy.Add(compliance.Name,compliance);
            Energy missing = new Energy("Missing laser pistol", 11, 1.5, 11, 3.8, 3, 30);
            energy.Add(missing.Name, missing);
            Energy pewpew = new Energy("Pew Pew", 75, 2.5, 50, 2, 3, 2);
            energy.Add(pewpew.Name, pewpew);
            Energy plasmaDef = new Energy("Plasma Defender", 38, 1, 38, 2.5, 2, 16);
            energy.Add(plasmaDef.Name, plasmaDef);
            Energy plasmaDefGRA = new Energy("Plasma Defender (GRA)", 38, 1, 38, 2.5, 2, 16);
            energy.Add(plasmaDefGRA.Name, plasmaDefGRA);
            Energy plasPist = new Energy("Plasma pistol", 33, 1.5, 33, 1.8, 2, 16);
            energy.Add(plasPist.Name, plasPist);
            Energy plasPistGRA = new Energy("Plasma pistol (GRA)", 33, 1.5, 33, 1.8, 2, 16);
            energy.Add(plasPistGRA.Name, plasPistGRA);
            Energy pulse = new Energy("Pulse gun", 5, 1, 5, 1, 2, 5);
            energy.Add(pulse.Name, pulse);
            Energy recharPist = new Energy("Recharger pistol", 18, 1.2, 18, 5, 3, 20);
            energy.Add(recharPist.Name, recharPist);
            Energy mfhyper = new Energy("MF Hyperbreeder Alpha (GRA)", 25, 0.24, 25, 7, 10, 3);
            energy.Add(mfhyper.Name, mfhyper);
            Energy seG = new Energy("Sonic emitter - Gabriel's bark", 55, 1, 25, 1, 12, 2);
            energy.Add(seG.Name, seG);
            Energy seO = new Energy("Sonic emitter - opera singer", 55, 1, 25, 1, 24, 2);
            energy.Add(seO.Name, seO);
            Energy seR = new Energy("Sonic emitter - revelation", 31, 1, 18, 1, 2, 24);
            energy.Add(seR.Name, seR);
            Energy seRS = new Energy("Sonic emitter - robo-scorpion", 65, 1, 130, 1, 2, 8);
            energy.Add(seRS.Name, seRS);
            Energy seT = new Energy("Sonic emitter - tarantula", 60, 1, 30, 1, 2, 8);
            energy.Add(seT.Name, seT);
            Energy gauss = new Energy("Gauss rifle", 120, 2, 60, 3, 2.3, 1);
            energy.Add(gauss.Name, gauss);
            Energy gaussUnique = new Energy("YCS/186", 140, 2, 70, 3, 2.3, 1);
            energy.Add(gaussUnique.Name, gaussUnique);
            Energy holo = new Energy("Holorifle", 80, 1, 80, 1.1, 0.5 * 4, 4);
            energy.Add(holo.Name, holo);
            Energy laer = new Energy("LAER", 65, 1.5, 15, 2.5, 3, 20);
            energy.Add(laer.Name, laer);
            Energy laerUnique = new Energy("Elijah's advanced LAER", 65, 1.5, 15, 2.8, 3, 15);
            energy.Add(laerUnique.Name, laerUnique);
            Energy rcw = new Energy("Laser RCW", 15, 0.05, 15, 9, 1.8, 60);
            energy.Add(rcw.Name, rcw);
            Energy lasRifle = new Energy("Laser rifle", 22, 1.5, 22, 3.1, 2.5, 24);
            energy.Add(lasRifle.Name, lasRifle);
            Energy aer14 = new Energy("AER14 prototype", 35, 2, 35, 3, 2.5, 12);
            energy.Add(aer14.Name, aer14);
            Energy vgLas = new Energy("Van Graff laser rifle", 15, 1.5, 15, 3.1, 2.5, 24);
            energy.Add(vgLas.Name, vgLas);
            Energy multiplas = new Energy("Multiplas rifle", 105, 1, 34 * 3, 1, 3, 10);
            energy.Add(multiplas.Name, multiplas);
            Energy plasRifle = new Energy("Plasma rifle", 47, 2, 47, 1.4, 3, 12);
            energy.Add(plasRifle.Name, plasRifle);
            Energy vgPlas = new Energy("Van Graff plasma rifle", 32, 2, 32, 1.4, 3, 12);
            energy.Add(vgPlas.Name, vgPlas);
            Energy q35 = new Energy("Q-35 matter modulator", 40, 2, 62, 2.4, 3, 12);
            energy.Add(q35.Name, q35);
            Energy recharRifle = new Energy("Recharger rifle", 12, 1.5, 12, 4.3, 3, 7);
            energy.Add(recharRifle.Name, recharRifle);
            Energy tribeam = new Energy("Tri-beam laser rifle", 66, 1.5, 22 * 3, 2.7, 2.5, 8);
            energy.Add(tribeam.Name, tribeam);
            Energy tribeamGRA = new Energy("Tri-beam laser rifle (GRA)", 66, 1.5, 22 * 3, 2.7, 2.5, 8);
            energy.Add(tribeamGRA.Name, tribeamGRA);
            Energy arcWelder = new Energy("Arc welder", 9, 0.36, 1, 8, 1.5, 30);
            energy.Add(arcWelder.Name, arcWelder);
            Energy flamer = new Energy("Flamer", 18, 0.42, 1, 8, 1.5, 60);
            energy.Add(flamer.Name, flamer);
            Energy cleanse = new Energy("Cleansing Flame (GRA)", 25, 0.1, 1, 7, 1.5, 100);
            energy.Add(cleanse.Name, cleanse);
            Energy gLas = new Energy("Gatling laser", 10, 0.02, 10, 30, 3, 240);
            energy.Add(gLas.Name, gLas);
            Energy gLasUnique = new Energy("Sprtel-Wood 9700 (GRA)", 16, 0.04, 16, 20, 3, 90);
            energy.Add(gLasUnique.Name, gLasUnique);
            Energy hIncinerator = new Energy("Heavy incinerator", 42, 0.83, 5, 4, 1.5, 24);
            energy.Add(hIncinerator.Name, hIncinerator);
            Energy incinerator = new Energy("Incinerator", 25, 1.67, 1, 2, 1.5, 30);
            energy.Add(incinerator.Name, incinerator);
            Energy pCaster = new Energy("Plasma caster", 65, 1, 65, 3, 3, 10);
            energy.Add(pCaster.Name, pCaster);
            Energy smitty = new Energy("The Smitty Special (GRA)", 35, 0.1, 35, 7, 3, 20);
            energy.Add(smitty.Name, smitty);
            Energy tesla = new Energy("Tesla cannon", 100, 2, 40, 1.3, 3.2, 4);
            energy.Add(tesla.Name,tesla);
            Energy elijahTesla = new Energy("Elijah's jury-rigged Tesla cannon", 105, 2, 45, 1.6, 3.2, 6);
            energy.Add(elijahTesla.Name, elijahTesla);
            Energy teslaBeaton = new Energy("Tesla-Beaton prototype", 115, 2, 45, 1.3, 3.2, 4);
            energy.Add(teslaBeaton.Name, teslaBeaton);

            Dictionary<string, Explosive> explosive = new Dictionary<string, Explosive>();
            Explosive apw = new Explosive("25mm grenade APW (GRA)", 52, 2.5, 2.2, 6);
            explosive.Add(apw.Name, apw);
            Explosive fatMan = new Explosive("Fat Man", 1000, 1.6, 3, 1);
            explosive.Add(fatMan.Name, fatMan);
            Explosive fatManGRA = new Explosive("Fat Man (GRA)", 1000, 1.6, 3, 1);
            explosive.Add(fatManGRA.Name, fatManGRA);
            Explosive esther = new Explosive("Esther (GRA)", 1075, 1.9, 3, 1);
            explosive.Add(esther.Name, esther);
            Explosive gmg = new Explosive("Grenade machinegun", 50, 3, 4, 30);
            explosive.Add(gmg.Name, gmg);
            Explosive mercy = new Explosive("Mercy", 105, 3.1, 4, 18);
            explosive.Add(mercy.Name, mercy);
            Explosive gl = new Explosive("Grenade launcher", 130, 0.6, 0.5 * 4, 4);
            explosive.Add(gl.Name, gl);
            Explosive gr = new Explosive("Grenade rifle", 102, 2.1, 2, 1, 1, 1);
            explosive.Add(gr.Name, gr);
            Explosive greatBear = new Explosive("Great Bear grenade rifle", 115, 2.1, 2, 1, 1, 15);
            explosive.Add(greatBear.Name, greatBear);
            Explosive mercGR = new Explosive("Mercenary's grenade rifle", 102, 2.1, 2, 1, 1, 1);
            explosive.Add(mercGR.Name, mercGR);
            Explosive redVictory = new Explosive("Red Victory grenade rifle", 102, 3.2, 2, 1, 1, 1);
            explosive.Add(redVictory.Name, redVictory);
            Explosive thump = new Explosive("Thump-Thump", 102, 2.8, 2, 1, 1, 1);
            explosive.Add(thump.Name, thump);
            Explosive launcher = new Explosive("Missile launcher", 325, 1.6, 4, 1);
            explosive.Add(launcher.Name, launcher);
            Explosive annabelle = new Explosive("Annabelle", 350, 1.9, 4, 1);
            explosive.Add(annabelle.Name, annabelle);
            Explosive redGlare = new Explosive("Red Glare", 60, 4, 6.8, 13);
            explosive.Add(redGlare.Name, redGlare);
            Explosive dynamite = new Explosive("Dynamite", 76, 0.4);
            explosive.Add(dynamite.Name, dynamite);
            Explosive fire = new Explosive("Fire bomb", 25, 0.4);
            explosive.Add(fire.Name, fire);
            Explosive flash = new Explosive("Flash bang", 1, 0.7);
            explosive.Add(flash.Name, flash);
            Explosive frag = new Explosive("Frag grenade", 126, 0.7);
            explosive.Add(frag.Name, frag);
            Explosive holyFrag = new Explosive("Holy Frag Frenade", 801, 0.7);
            explosive.Add(holyFrag.Name, holyFrag);
            Explosive incendiary = new Explosive("Incendiary grenade", 57, 0.7);
            explosive.Add(incendiary.Name, incendiary);
            Explosive lfDynamite = new Explosive("Long-fuse dynamite", 76, 0.4);
            explosive.Add(lfDynamite.Name, lfDynamite);
            Explosive mfcGrenade = new Explosive("MFC grenade (GRA)", 76, 0.7);
            explosive.Add(mfcGrenade.Name, mfcGrenade);
            Explosive nuka = new Explosive("Nuka-grenade (GRA)", 353, 0.7);
            explosive.Add(nuka.Name, nuka);
            Explosive plasGren = new Explosive("Plasma grenade", 226, 0.7);
            explosive.Add(plasGren.Name, plasGren);
            Explosive pulseGren = new Explosive("Pulse grenade", 11, 0.7);
            explosive.Add(pulseGren.Name, pulseGren);
            Explosive tin = new Explosive("Tin grenade (GRA)", 101, 0.7);
            explosive.Add(tin.Name, tin);
            Explosive bMine = new Explosive("Bottlecap mine", 200);
            explosive.Add(bMine.Name, bMine);
            Explosive c4 = new Explosive("C-4 plastic explosive", 250);
            explosive.Add(c4.Name, c4);
            Explosive demo = new Explosive("Demolition charge", 100);
            explosive.Add(demo.Name, demo);
            Explosive fatMine = new Explosive("Fat mine (GRA)", 450);
            explosive.Add(fatMine.Name, fatMine);
            Explosive fragMine = new Explosive("Frag mine", 100);
            explosive.Add(fragMine.Name, fragMine);
            Explosive gas = new Explosive("Gas bomb", 82);
            explosive.Add(gas.Name, gas);
            Explosive cluster = new Explosive("MFC cluster (GRA)", 450);
            explosive.Add(cluster.Name, cluster);
            Explosive plasmaMine = new Explosive("Plasma mine", 150);
            explosive.Add(plasmaMine.Name, plasmaMine);
            Explosive powder = new Explosive("Powder charge", 75);
            explosive.Add(powder.Name, powder);
            Explosive pulseMine = new Explosive("Pluse mine", 10);
            explosive.Add(pulseMine.Name, pulseMine);
            Explosive satchel = new Explosive("Satchel charge", 250);
            explosive.Add(satchel.Name, satchel);
            Explosive time = new Explosive("Time bomb", 150);
            explosive.Add(time.Name, time);
            Explosive timeHigh = new Explosive("Time bomb, high yield (GRA)", 400);
            explosive.Add(timeHigh.Name, timeHigh);

            Dictionary<string, Melee> melee = new Dictionary<string, Melee>();
            Melee cosKnifeSH = new Melee("Cosmic knife super-heated", 14, 5, 14, 3, false);
            melee.Add(cosKnifeSH.Name, cosKnifeSH);
            Melee figaro = new Melee("Figaro", 8, 4, 16, 4.2, false);
            melee.Add(figaro.Name, figaro);
            Melee liberator = new Melee("Liberator", 18, 3, 18, 3.5, false);
            melee.Add(liberator.Name, liberator);
            Melee chopper = new Melee("Chopper", 14, 2, 14, 3.9, false);
            melee.Add(chopper.Name, chopper);
            Melee cKnife = new Melee("Combat knife", 15, 2, 15, 3.2, false);
            melee.Add(cKnife.Name, cKnife);
            Melee chance = new Melee("Chance's knife", 22, 2, 22, 4.2, false);
            melee.Add(chance.Name, chance);
            Melee razor = new Melee("Straight razor", 5, 2, 10, 3.7, false);
            melee.Add(razor.Name, razor);
            Melee shishkebab = new Melee("Shishkebab", 42, 2, 20, 2.3, false);
            melee.Add(shishkebab.Name, shishkebab);
            Melee katana = new Melee("Katana (GRA)", 22, 2, 22, 3.2, false);
            melee.Add(katana.Name, katana);
            Melee bMachete = new Melee("Broad Machete", 15, 2, 15, 3.2, false);
            melee.Add(bMachete.Name, bMachete);
            Melee switchblade = new Melee("Switchblade", 7, 2, 11, 2, false);
            melee.Add(switchblade.Name, switchblade);
            Melee gehenna = new Melee("Gehenna (GRA)", 47, 2, 21, 2.8, false);
            melee.Add(gehenna.Name, gehenna);
            Melee machete = new Melee("Machete", 11, 1.5, 11, 3, false);
            melee.Add(machete.Name, machete);
            Melee bowie = new Melee("Bowie knife", 23, 1.5, 35, 3.5, false);
            melee.Add(bowie.Name, bowie);
            Melee bloodnap = new Melee("Blood-Nap", 30, 1.5, 45, 3.7, false);
            melee.Add(bloodnap.Name, bloodnap);
            Melee west = new Melee("Blade of the West", 60, 1.5, 30, 2.1, false);
            melee.Add(west.Name, west);
            Melee gMachete = new Melee("Machete gladius", 28, 1.5, 28, 3, false);
            melee.Add(gMachete.Name, gMachete);
            Melee spearClean = new Melee("Knife spear clean", 25, 1.2, 25, 1.9, false);
            melee.Add(spearClean.Name, spearClean);
            Melee cosKnifeClean = new Melee("Cosmic knife clean", 15, 1.2, 15, 3, false);
            melee.Add(cosKnifeClean.Name, cosKnifeClean);
            Melee ripper = new Melee("Ripper", 50, 1, 5, 1, false);
            melee.Add(ripper.Name, ripper);
            Melee ripperGRA = new Melee("Ripper (GRA)", 50, 1, 5, 1, false);
            melee.Add(ripperGRA.Name, ripperGRA);
            Melee lance = new Melee("Thermic lance", 100, 1, 10, 1, false);
            melee.Add(lance.Name, lance);
            Melee knife = new Melee("Knife", 8, 1, 8, 3, false);
            melee.Add(knife.Name, knife);
            Melee spear = new Melee("Knife spear", 20, 1, 20, 1.9, false);
            melee.Add(spear.Name, spear);
            Melee proIAx = new Melee("Protonic inversal axe", 58, 1, 45, 1.9, false);
            melee.Add(proIAx.Name, proIAx);
            Melee proAx = new Melee("Proton axe", 50, 1, 25, 1.9, false);
            melee.Add(proAx.Name, proAx);
            Melee bumper = new Melee("Bummper sword", 32, 1, 32, 1.4, false);
            melee.Add(bumper.Name, bumper);
            Melee east = new Melee("Blade of the East", 67, 1, 30, 1.5, false);
            melee.Add(east.Name, east);
            Melee hatchet = new Melee("Hatchet", 16, 1, 16, 2.5, false);
            melee.Add(hatchet.Name, hatchet);
            Melee knock = new Melee("Knock-Knock", 66, 1, 33, 1.8, false);
            melee.Add(knock.Name, knock);
            Melee fAxe = new Melee("Fire axe", 55, 1, 27, 1.6, false);
            melee.Add(fAxe.Name, fAxe);
            Melee cosKnife = new Melee("Cosmic knife", 12, 1, 12, 3, false);
            melee.Add(cosKnife.Name, cosKnife);
            Melee cleaver = new Melee("Cleaver", 7, 1, 7, 2.5, false);
            melee.Add(cleaver.Name, cleaver);
            Melee chainsaw = new Melee("Chainsaw", 80, 1, 8, 1, false);
            melee.Add(chainsaw.Name, chainsaw);
            Melee chainsawGRA = new Melee("Chainsaw (GRA)", 80, 1, 8, 1, false);
            melee.Add(chainsawGRA.Name, chainsawGRA);
            Melee golf = new Melee("9 iron", 17, 1, 17, 2.3, false);
            melee.Add(golf.Name, golf);
            Melee nephi = new Melee("Nephi's golf driver", 30, 1.2, 30, 2.3, false);
            melee.Add(nephi.Name, nephi);
            Melee baseball = new Melee("Baseball bat", 22, 1, 22, 1.7, false);
            melee.Add(baseball.Name, baseball);
            Melee baseballGRA = new Melee("Baseball bat (GRA)", 22, 1, 22, 1.7, false);
            melee.Add(baseballGRA.Name, baseballGRA);
            Melee prod = new Melee("Cattle prod", 5, 2, 5, 2.3, false);
            melee.Add(prod.Name, prod);
            Melee cane = new Melee("Dress cane", 22, 1, 35, 2.3, false);
            melee.Add(cane.Name, cane);
            Melee pipe = new Melee("Lead pipe", 22, 1, 22, 2.5, false);
            melee.Add(pipe.Name, pipe);
            Melee cudgel = new Melee("The Humble Cudgel", 26, 1, 26, 2.8, false);
            melee.Add(cudgel.Name, cudgel);
            Melee board = new Melee("Nail board", 25, 0, 25, 1.4, false);
            melee.Add(board.Name, board);
            Melee glory = new Melee("Old Glory", 45, 1.5, 80, 1.9, false);
            melee.Add(glory.Name, glory);
            Melee cue = new Melee("Pool cue", 15, 0, 15, 1.6, false);
            melee.Add(cue.Name, cue);
            Melee baton = new Melee("Police baton", 10, 1, 10, 2.8, false);
            melee.Add(baton.Name, baton);
            Melee rebar = new Melee("Rebar club", 42, 0.5, 24, 1.3, false);
            melee.Add(rebar.Name, rebar);
            Melee breaker = new Melee("Nuka Breaker (GRA)", 50, 2, 50, 1.4, false);
            melee.Add(breaker.Name, breaker);
            Melee pin = new Melee("Rolling pin", 3, 0, 8, 1.7, false);
            melee.Add(pin.Name, pin);
            Melee shovel = new Melee("Shovel", 12, 3, 20, 1.7, false);
            melee.Add(shovel.Name, shovel);
            Melee hammer = new Melee("Sledgehammer", 24, 1, 24, 1.9, false);
            melee.Add(hammer.Name, hammer);
            Melee sSledge = new Melee("Super sledge", 70, 1, 35, 1.6, false);
            melee.Add(sSledge.Name, sSledge);
            Melee baby = new Melee("Oh, Baby!", 80, 1, 40, 1.7, false);
            melee.Add(baby.Name, baby);
            Melee tire = new Melee("Tire iron", 15, 1, 15, 2.3, false);
            melee.Add(tire.Name, tire);
            Melee warClub = new Melee("War club", 19, 1, 19, 3, false);
            melee.Add(warClub.Name, warClub);
            Melee x2 = new Melee("X-2 antenna", 65, 1, 23, 1.1, false);
            melee.Add(x2.Name, x2);
            Melee proAxT = new Melee("Proton throwing axe", 40, 1, 29, 0.8, true);
            melee.Add(proAxT.Name, proAxT);
            Melee proIAxT = new Melee("Protonic inversal throwing axe", 60, 1, 29, 0.9, true);
            melee.Add(proIAxT.Name, proIAxT);
            Melee hatchetT = new Melee("Throwing hatchet", 20, 1, 20, 0.9, true);
            melee.Add(hatchetT.Name, hatchetT);
            Melee knifeT = new Melee("Throwing knife", 15, 2, 15, 3.2, true);
            melee.Add(knifeT.Name, knifeT);
            Melee spearTK = new Melee("Throwing knife spear", 42, 1, 42, 0.5, true);
            melee.Add(spearTK.Name, spearTK);
            Melee spearT = new Melee("Throwing spear", 50, 1, 50, 0.6, true);
            melee.Add(spearT.Name, spearT);
            Melee tomohawk = new Melee("Tomohawk", 30, 1, 30, 0.7, true);
            melee.Add(tomohawk.Name, tomohawk);

            Dictionary<string, Unarmed> unarmed = new Dictionary<string, Unarmed>();
            Unarmed bFist = new Unarmed("Ballistic fist", 80, 1, 80, 1.1);
            unarmed.Add(bFist.Name, bFist);
            Unarmed tsg = new Unarmed("Two-Step Goodbye", 70, 4, 10, 1.1);
            unarmed.Add(tsg.Name, tsg);
            Unarmed trap = new Unarmed("Bear trap fist", 27, 1, 27, 1.1);
            unarmed.Add(trap.Name, trap);
            Unarmed bladedG = new Unarmed("Bladed gauntlet", 25, 2, 40, 1.6);
            unarmed.Add(bladedG.Name, bladedG);
            Unarmed cram = new Unarmed("Cram Opener", 28, 2, 44, 1.7);
            unarmed.Add(cram.Name, cram);
            Unarmed bGloves = new Unarmed("Boxing gloves", 1, 1, 1, 1.3);
            unarmed.Add(bGloves.Name, bGloves);
            Unarmed gGloves = new Unarmed("Golden Gloves", 1, 2, 1, 1.3);
            unarmed.Add(gGloves.Name, gGloves);
            Unarmed tape = new Unarmed("Boxing tape", 4, 1, 4, 1.3);
            unarmed.Add(tape.Name, tape);
            Unarmed bKnuckles = new Unarmed("Brass knuckles", 18, 1, 18, 2.1);
            unarmed.Add(bKnuckles.Name, bKnuckles);
            Unarmed displacer = new Unarmed("Displacer glove", 50, 1, 50, 1.4);
            unarmed.Add(displacer.Name, displacer);
            Unarmed pushy = new Unarmed("Pushy", 60, 1, 60, 1.5);
            unarmed.Add(pushy.Name, pushy);
            Unarmed tags = new Unarmed("Dog tag fist", 20, 1, 20, 1.6);
            unarmed.Add(tags.Name, tags);
            Unarmed fallen = new Unarmed("Recompense of the Fallen", 25, 1, 25, 1.9);
            unarmed.Add(fallen.Name, fallen);
            Unarmed rawr = new Unarmed("Fist of Rawr", 50, 2, 75, 2);
            unarmed.Add(rawr.Name, rawr);
            Unarmed iHand = new Unarmed("Industrial hand", 50, 1, 40, 3.2);
            unarmed.Add(iHand.Name, iHand);
            Unarmed mantis = new Unarmed("Mantis gauntlet", 30, 3, 30, 2);
            unarmed.Add(mantis.Name, mantis);
            Unarmed embrace = new Unarmed("Embrace of the Mantis King! (GRA)", 42, 3, 64, 1.6);
            unarmed.Add(embrace.Name, embrace);
            Unarmed pFist = new Unarmed("Power fist", 40, 1, 40, 1.1);
            unarmed.Add(pFist.Name, pFist);
            Unarmed pFistGRA = new Unarmed("Power fist (GRA)", 40, 1, 40, 1.1);
            unarmed.Add(pFistGRA.Name, pFistGRA);
            Unarmed sFist = new Unarmed("Saturnite fist", 35, 1, 35, 1.8);
            unarmed.Add(sFist.Name, sFist);
            Unarmed sFistSH = new Unarmed("Saturnite fist super-heated", 55, 1, 55, 1.7);
            unarmed.Add(sFistSH.Name, sFistSH);
            Unarmed grease = new Unarmed("Greased Lightning (GRA", 32, 1, 32, 3);
            unarmed.Add(grease.Name, grease);
            Unarmed salt = new Unarmed("Salt-Upon-Wounds' power fist", 45, 1, 45, 1.4);
            unarmed.Add(salt.Name, salt);
            Unarmed sciGlove = new Unarmed("Scientist glove", 21, 1.5, 5, 1.4);
            unarmed.Add(sciGlove.Name, sciGlove);
            Unarmed corGlove = new Unarmed("Corrosive glove", 21, 1, 5, 1.1);
            unarmed.Add(corGlove.Name, corGlove);
            Unarmed sterGlove = new Unarmed("Sterilizer glove", 21, 1, 5, 1.4);
            unarmed.Add(sterGlove.Name, sterGlove);
            Unarmed klein = new Unarmed("Dr. Klein's glove", 34, 3, 5, 1.4);
            unarmed.Add(klein.Name, klein);
            Unarmed mobius = new Unarmed("Dr. Mobius' glove", 28, 2, 5, 1.4);
            unarmed.Add(mobius.Name, mobius);
            Unarmed sKnuckles = new Unarmed("Spiked knuckles", 25, 1, 25, 2.4);
            unarmed.Add(sKnuckles.Name, sKnuckles);
            Unarmed lovehate = new Unarmed("Love and Hate", 30, 1, 30, 2.5);
            unarmed.Add(lovehate.Name, lovehate);
            Unarmed yaoguai = new Unarmed("Yao guai gauntlet", 20, 2.5, 30, 1.6);
            unarmed.Add(yaoguai.Name, yaoguai);
            Unarmed she = new Unarmed("She's Embrace", 25, 3, 37, 1.8);
            unarmed.Add(she.Name, she);
            Unarmed zap = new Unarmed("Zap glove", 35, 1, 35, 1.6);
            unarmed.Add(zap.Name, zap);
            Unarmed toaster = new Unarmed("Paladin Toaster", 41, 1, 41, 1.6);
            unarmed.Add(toaster.Name, toaster);



            //Check user's Strength and Luck
            Console.WriteLine("Okay. Let's start with something easy. What's your character's strength?");
            byte str = Byte.Parse(Console.ReadLine());
            Console.WriteLine("Cool. What about their Luck?");
            byte luck = Byte.Parse(Console.ReadLine());

            //Check user's perks
            Console.WriteLine("Okay. Here comes the rough stuff. It's time for perks.");
            Thread.Sleep(1500);
            Console.WriteLine("Light Touch assumes you're in light armor. For your sake and mine, please don't cheat on this.");

            string splitter = "";
            Thread.Sleep(1500);

            for (int i = 0; i < fullPerkArray.Length; i++)
            {
                Console.Clear();
                Console.WriteLine($"Does your character have {fullPerkArray[i]}?\n" +
                    "0: No\n" +
                    "1: Yes");
                byte input = Byte.Parse(Console.ReadLine());

                Character.PerkChoice perkChoice = (Character.PerkChoice)input;

                switch (perkChoice)
                {
                    case Character.PerkChoice.Yes:
                        splitter += ($"{fullPerkArray[i]},");
                        break;
                    case Character.PerkChoice.No:
                        break;
                    default:
                        Console.WriteLine("Sorry, limitations. That counts as a no.");
                        Thread.Sleep(500);
                        break;
                }

                Thread.Sleep(500);
            }

            //Creates an array from user input
            splitter = splitter.Substring(0, splitter.Length - 1);
            string[] perkArray = splitter.Split(',');

            //Creates a new Character object
            Character courier = new Character(str, luck, 5, perkArray);

            //Ask about gear
            Dictionary<string, double> gear = new Dictionary<string, double>();
            gear.Add("1st Recon beret", 0.05);
            gear.Add("Armor of the 87th Tribe?", 0.03);
            gear.Add("Elite riot gear", 0.05);
            gear.Add("Ulysses' duster", 0.05);
            gear.Add("Joshua Graham's armor", 0.03);
            gear.Add("Salt-Upon-Wound's helmet", 0.02);
            gear.Add("Marked beast face helmet", 0.02);

            foreach(KeyValuePair<string, double> item in gear)
            {
                Console.WriteLine($"Are you wearing {item.Key}?\n" +
                    "0: No\n" +
                    "1: Yes");

                byte input = Byte.Parse(Console.ReadLine());

                Character.PerkChoice choice = (Character.PerkChoice)input;

                switch (choice)
                {
                    case Character.PerkChoice.Yes:
                        courier.CritChance += item.Value;
                        break;
                    case Character.PerkChoice.No:
                        break;
                    default:
                        Console.WriteLine("Sorry, limitations. That counts as a no.");
                        Thread.Sleep(500);
                        break;
                }

                Thread.Sleep(500);
                Console.Clear();
            }

            //Asks which weapon to look for
            Console.Clear();
            Console.WriteLine("What weapon are you looking for?");

            string answer = Console.ReadLine();

            if(guns.ContainsKey(answer))
            {
                courier.CharacterPerks(guns[answer]);
                guns[answer].GunsPerks(courier);
                courier.LightTouchCheck();

                double finalCrit = Math.Min(1,courier.CritChance * guns[answer].CritMult);
                double fullDam = guns[answer].Damage + guns[answer].CritDamage;
                double damageMult = guns[answer].DamageMultPerks(courier);
                double finalDamage = (guns[answer].Damage + guns[answer].CritDamage * finalCrit) * damageMult;


                Console.WriteLine($"With {guns[answer].Name}, you are going to deal {guns[answer].Damage} base damage per attack, and {guns[answer].Damage * damageMult} after perk modifiers.\n" +
                    $"If you land a critical hit, you deal an extra {guns[answer].CritDamage} base damage for a total of {fullDam * damageMult} after perks.\n" +
                    $"With your final crit chance of {courier.CritChance * guns[answer].CritMult * 100}%, you'll do an average of {finalDamage} per attack.");
            }
        }
    }
}
