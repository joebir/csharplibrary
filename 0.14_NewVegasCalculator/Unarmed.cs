using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_NewVegasCalculator
{
    class Unarmed: Weapon
    {
        public Unarmed(string name, double damage, double critMultiplier, double critDamage, double speed)
        {
            this.Name = name;
            this.Damage = damage;
            this.CritMult = critMultiplier;
            this.CritDamage = critDamage;
            this.Speed = speed;
        }

        //Methods
        public void UnarmedPerks(Character courier)
        {
            //Heavy Handed: +20% damage; -60% critical damage
            if (courier.Perks.Contains("Heavy Handed"))
            {
                this.Damage *= 1.2;
                this.CritDamage *= 0.4;
            }

            this.WeaponDamagePerks(courier);
            this.WeaponSpeedPerks(courier);

            //Bonus damage
            this.Damage += 5.5;
        }
    }
}
