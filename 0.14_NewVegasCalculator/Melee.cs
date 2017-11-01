using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_NewVegasCalculator
{
    class Melee : Weapon
    {
        //Constructor
        public Melee(string name, double damage, double critMultiplier, double critDamage, double speed, bool thrown)
        {
            this.Name = name;
            this.Damage = damage;
            this.CritMult = critMultiplier;
            this.CritDamage = critDamage;
            this.Speed = speed;
            this.IsThrown = thrown;
        }

        public bool IsThrown { get; set; }

        //Methods
        public void MeleePerks(Character courier)
        {
            //Elijah's Ramblings: +150% critical damage
            if(courier.Perks.Contains("Elijah's Ramblings"))
            {
                this.CritDamage *= 1.5;
            }

            //Heavy Handed: +20% damage; -60% critical damage
            if(courier.Perks.Contains("Heavy Handed"))
            {
                this.Damage *= 1.2;
                this.CritDamage *= 0.4;
            }

            //Call the rest of the perks
            this.WeaponDamagePerks(courier);
            this.WeaponSpeedPerks(courier);

            //Bonus damage
            this.Damage += (courier.Strength * 0.5);
        }
    }
}
