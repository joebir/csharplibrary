using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_OOPGame
{
    public abstract class Character
    {
        //Constants
        const int Min_Heath = 1;

        //Properties
        public string Name { get; set; }
        public bool IsAlive { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }
        public int AttackLevel { get; set; }
        public int Stamina { get; set; }
        public int Luck { get; set; }

        //Methods
        public string Attack()
        {
            Random rnd = new Random();
            int lowAttack = (int)Math.Round(AttackLevel * 0.9);
            int highAttack = (int)Math.Round(AttackLevel * 1.1);
            int damage = rnd.Next(lowAttack, highAttack + 1);

            int crit = rnd.Next(0, 21);
            if(this.Luck >= crit)
            {
                Console.WriteLine("Critical Hit!");
                damage = (int)Math.Round(damage * 1.5);
            }

            return ("Damage: " + damage.ToString());
        }
    }
}
