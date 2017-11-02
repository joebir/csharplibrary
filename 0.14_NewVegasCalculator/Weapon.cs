using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_NewVegasCalculator
{
    public abstract class Weapon
    {
        //Properties
        public string Name { get; set; }
        public double Damage { get; set; }
        public double CritMult { get; set; }
        public double CritDamage { get; set; }
        public double Speed { get; set; }
        public double ReloadTime { get; set; }
        public byte Magazine { get; set; }

        //Weapon-Specific Perk Arrays
        string[] professionalArray = {".357 Magnum revolver","Lucky",".44 Magnum revolver","Mysterious Magnum",".45 Auto pistol",
            "A Light Shining in Darkness",".45 Auto submachine gun","5.56mm pistol","9mm pistol","Maria","9mm submachine gun",
            "Vance's 9mm submachine gun","10mm pistol","10mm submachine gun","Sleepytyme","12.7mm pistol","Li'l Devil",
            "12.7mm submachine gun","12.7mm submachine gun (GRA)","Alien Blaster","Compliance Regulator","Hunting revolver",
            "Hunting revolver (GRA)","Laser pistol","Laser pistol (GRA)","Pew Pew","Laser RCW","H&H Tools nail gun","Plasma Defender",
            "Plasma Defender (GRA)","Plasma pistol","Plasma pistol (GRA)","Pulse gun","Ranger Sequoia","Recharger pistol",
            "MF Hyperbreeder Alpha (GRA)","Silenced .22 pistol","Silenced .22 SMG","Sonic emitter - Gabriel's bark",
            "Sonic emitter - opera singer","Sonic emitter - revelation","Sonic emitter - robo-scorpion","Sonic emitter - tarantula"};
        string[] laserCommanderArray = {"Arc welder","Gatling laser","Sprtel-Wood 9700 (GRA)","LAER","Elijah's advanced LAER","Laser pistol","Compliance Regulator","Laser pistol (GRA)",
            "Missing laser pistol","Pew Pew","Laser RCW","Laser rifle","AER14 prototype","Van Graff laser rifle","MF Hyperbreeder Alpha (GRA)","Pulse gun","Sonic emitter - Gabriel's bark","Sonic emitter - opera singer","Sonic emitter - revelation","Sonic emitter - robo-scorpion","Sonic emitter - tarantula","Tri-beam laser rifle",
            "Tri-beam laser rifle (GRA)" };
        string[] cowboyArray = {"Dynamite","Long-fuse dynamite","Fire bomb","Time bomb","Bowie knife","Blood-Nap","Combat knife","Chance's knife","Hatchet","Knife","Throwing hatchet","Throwing knife",
        "Tomohawk","War club",".357 Magnum revolver","Lucky",".44 Magnum Revolver","Mysterious Magnum","5.56mm pistol","That Gun","BB gun","Abilene Kid LE BB gun","Brush gun","Medicine Stick (GRA)",
        "Cowboy repeater","La Longue Carabine","Hunting revolver","Hunting revolver (GRA)","Lever-action shotgun","Ranger Sequoia","Trail carbine" };
        string[] gruntArray = {"9mm pistol","Maria","9mm submachine gun","Vance's 9mm submachine gun",".45 auto pistol","A Light Shining in Darkness",".45 Auto submachine gun","Service rifle",
            "Survivalist's rifle","Assault carbine","Marksman carbine","All-American","Light machine gun","Frag grenade","Holy Frag Grenade","Grenade rifle","Thump-Thump","Grenade launcher",
            "Combat knife","Chance's Knife"};
        string[] fullAutoArray = { "Assault Carbine", "Assault Carbine (GRA)", "Light machine gun", "Bozar (GRA)", ".45 Auto submachine gun", "9mm submachine gun", "Vance's 9mm submachine gun",
            "10mm submachine gun", "Sleepytyme", "12.7mm submachine gun", "12.7mm submachine gun (GRA)", "H&H Tools nail gun", "Silenced .22 submachine gun", "K900 cyberdog gun", "FIDO", "Minigun",
            "CZ57 Avenger", "Shoulder mounted machine gun", "Laser RCW", "Arc welder", "Flamer", "Cleansing Flame (GRA)", "Gatling Laser", "Sprtel-Wood 9700"};


        //Methods
        public void WeaponDamagePerks(Character courier)
        {
            //Better Criticals: +50% to critical damage
            if (courier.Perks.Contains("Better Criticals"))
            {
                this.CritDamage *= 1.5;
            }
            //Just Lucky I'm Alive: +50% to critical damage
            if (courier.Perks.Contains("Just Lucky I'm Alive"))
            {
                this.CritDamage *= 1.5;
            }

            //The Professional: +25% critical damage
            if (courier.Perks.Contains("The Professional") && professionalArray.Contains(this.Name))
            {
                this.CritDamage *= 1.25;
            }
        }

        public void WeaponSpeedPerks(Character courier)
        {
            double speedMult = 1;
            //Ain't Like That Now: +20% attack speed
            if (courier.Perks.Contains("Ain't Like That Now") && fullAutoArray.Contains(this.Name) == false)
            {
                speedMult += 0.2;
            }

            //Fast Shot: +20% attack speed
            if (courier.Perks.Contains("Fast Shot") && fullAutoArray.Contains(this.Name) == false && this is Gun || courier.Perks.Contains("Fast Shot") && fullAutoArray.Contains(this.Name) == false && this is Energy)
            {
                speedMult += 0.2;
            }

            //Melee Hacker: +5/+10% attack speed
            if (courier.Perks.Contains("Melee Hacker Rank 1") && this is Melee || courier.Perks.Contains("Melee Hacker Rank 1") && this is Unarmed)
            {
                if (courier.Perks.Contains("Melee Hacker Rank 2"))
                {
                    speedMult += 0.1;
                }

                else
                {
                    speedMult += 0.05;
                }
            }

            //Slayer: +30% attack speed
            if (courier.Perks.Contains("Slayer") && this is Melee || courier.Perks.Contains("Slayer") && this is Unarmed)
            {
                speedMult += 0.3;
            }

            this.Speed *= speedMult;
        }

        public double DamageMultPerks(Character courier)
        {
            double damageMult = 1;
            //Bloody Mess: +5% to damage
            if (courier.Perks.Contains("Bloody Mess"))
            {
                damageMult *= 1.05;
            }

            //Lord Death: +1/+2/+4% to damage
            if (courier.Perks.Contains("Lord Death Rank 1"))
            {
                if (courier.Perks.Contains("Lord Death Rank 3") && courier.Perks.Contains("Lord Death Rank 2"))
                {
                    damageMult *= 1.04;
                }

                else if (courier.Perks.Contains("Lord Death Rank 2"))
                {
                    damageMult *= 1.02;
                }

                else
                {
                    damageMult *= 1.01;
                }
            }

            //Thought You Died: +10% to damage
            if (courier.Perks.Contains("Thought You Died"))
            {
                damageMult *= 1.1;
            }

            //Lonesome Road: +10% to damage
            if (courier.Perks.Contains("Lonesome Road"))
            {
                damageMult *= 1.1;
            }

            //Laser Commander: +15% damage
            if (courier.Perks.Contains("Laser Commander") && laserCommanderArray.Contains(this.Name))
            {
                damageMult *= 1.15;
            }

            return damageMult;
        }
    }
}
