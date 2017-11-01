using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_NewVegasCalculator
{
    class Explosive: Weapon
    {
        //Constructor
        public Explosive(string name, double damage, double speed, double reload, byte mag)
        {
            this.Name = name;
            this.Damage = damage;
            this.CritMult = 0;
            this.CritDamage = 0;
            this.Speed = speed;
            this.ReloadTime = reload;
            this.Magazine = mag;
        }

        //Methods
        public void ExplosivesPerks (Character courier)
        {
            //Demolition Expert: +20/+40/+60% damage
            if(courier.Perks.Contains("Demolition Expert Rank 1"))
            {
                if(courier.Perks.Contains("Demolition Expert Rank 3"))
                {
                    this.Damage *= 1.6;
                }

                else if(courier.Perks.Contains("Demolition Expert Rank 2"))
                {
                    this.Damage *= 1.4;
                }

                else
                {
                    this.Damage *= 1.2;
                }
            }

            this.WeaponDamagePerks(courier);
            this.WeaponSpeedPerks(courier);
        }
    }
}
