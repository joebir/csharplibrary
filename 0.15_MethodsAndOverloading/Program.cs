using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._15_MethodsAndOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Player pc = new Player();
            Console.WriteLine(pc.Attack(10));
            Console.WriteLine(pc.Attack(10,"training sword"));
            Console.WriteLine(pc.Attack(10,3,"training sword"));
        }
    }
}
