using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int amount = 600;

            if(amount > 10000)
            {
                Console.WriteLine("You seem like you've got some money in the bank.");
            }
            else
            {
                Console.WriteLine("Remember that time when you thought a 401k meant a $401,000 bank account? Yeah, me too.");
            }
        }
    }
}
