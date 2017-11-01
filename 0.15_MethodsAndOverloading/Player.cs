using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._15_MethodsAndOverloading
{
    class Player
    {
        public string Attack (int num)
        {
            return ($"Attacked for {num}!");
        }

        public string Attack (int num, string weapon)
        {
            return ($"Attacked for {num} with {weapon}!");
        }

        public string Attack (int num, int attacks, string weapon)
        {
            return ($"Attacked {attacks} times with {weapon}, dealing {num} damage each time for the total of a whopping {(num * attacks)} damage!");
        }
    }
}
