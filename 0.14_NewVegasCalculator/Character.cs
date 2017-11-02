using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_NewVegasCalculator
{
    public class Character
    {
        //Constructor
        public Character(byte str, byte luck, byte agi, string[] perks)
        {
            this.Strength = str;
            this.Luck = luck;
            this.Agility = agi;
            this.Perks = perks;
            this.CritChance = this.Luck / 100;
        }

        //Properties
        public byte Strength { get; set; }
        public byte Luck { get; set; }
        public byte Agility { get; set; }
        public string[] Perks { get; set; }
        public double CritChance { get; set; }

        //Enumerators
        public enum PerkChoice
        {
            No,
            Yes
        }

        //Laser Commander array
        public string[] laserCommanderArray = {"Arc welder","Gatling laser","Sprtel-Wood 9700 (GRA)","LAER","Elijah's advanced LAER","Laser pistol","Compliance Regulator","Laser pistol (GRA)",
            "Missing laser pistol","Pew Pew","Laser RCW","Laser rifle","AER14 prototype","Van Graff laser rifle","MF Hyperbreeder Alpha (GRA)","Pulse gun","Sonic emitter","Tri-beam laser rifle",
            "Tri-beam laser rifle (GRA)" };

        //Methods
        public void CharacterPerks(Weapon weapon)
        {
            //Finesse: +5% critical chance
            if(this.Perks.Contains("Finesse"))
            {
                this.CritChance += 0.05;
            }
 
            //Built to Destroy: +3% critical chance
            if (this.Perks.Contains("Built to Destroy"))
            {
                this.CritChance += 0.03;
            }

            //Laser Commander: +10% critical chance
            if (this.Perks.Contains("Laser Commander") && laserCommanderArray.Contains(weapon.Name))
            {
                this.CritChance += 0.1;
            }


            //Set Lasers for Fun: +2/+4% critical chance
            if(this.Perks.Contains("Set Lasers for Fun Rank 1"))
            {
                if (this.Perks.Contains("Set Lasers for Fun Rank 2"))
                {
                    this.CritChance += 0.04;
                }

                else if (this.Perks.Contains("Set Lasers for Fun Rank 1"))
                {
                    this.CritChance += 0.02;
                }
            }
        }

        public void NinjaPerkCheck(Weapon weapon)
        {
            //Ninja: Multiplicative +15% critical chance
            if (this.Perks.Contains("Ninja") && weapon is Melee || this.Perks.Contains("Ninja") && weapon is Unarmed)
            {
                this.CritChance = this.CritChance * 1.15;
            }
        }

        public void LightTouchCheck()
        {
            //Light Touch: Flat +5% critical chance after Ninja
            if(this.Perks.Contains("Light Touch"))
            {
                this.CritChance += 0.05;
            }
        }
    }
}
