﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_NewVegasCalculator
{
    class Energy: Weapon
    {
        //Constructor
        public Energy(string name, double damage, double critMultiplier, double critDamage, double speed, double reload, byte mag)
        {
            this.Name = name;
            this.Damage = damage;
            this.CritMult = critMultiplier;
            this.CritDamage = critDamage;
            this.Speed = speed;
            this.ReloadTime = reload;
            this.Magazine = mag;
        }

        public void EnergyPerks(Character courier)
        {
            this.WeaponDamagePerks(courier);
            this.WeaponSpeedPerks(courier);
        }
    }
}
