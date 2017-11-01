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

            Dictionary<string, Explosive> explosive = new Dictionary<string, Explosive>();
            Dictionary<string, Melee> melee = new Dictionary<string, Melee>();
            Dictionary<string, Unarmed> unarmed = new Dictionary<string, Unarmed>();



            
            

            //Check user's Strength and Luck
            Console.WriteLine("Okay. Let's start with something easy. What's your character's strength?");
            byte str = Byte.Parse(Console.ReadLine());
            Console.WriteLine("Cool. What about their Luck?");
            byte luck = Byte.Parse(Console.ReadLine());

            //Check user's perks
            Console.WriteLine("Okay. Here comes the rough stuff. It's time for perks.");

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
                        Console.WriteLine("Please enter 0 or 1.");
                        break;
                }

                Thread.Sleep(500);
            }

            //Creates an array from user input
            splitter = splitter.Substring(0, splitter.Length - 1);
            string[] perkArray = splitter.Split(',');

            //Creates a new Character object
            Character courier = new Character(str, luck, 5, perkArray);
        }
    }
}
