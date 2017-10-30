using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_OOPGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //It is pitch dark. You are likely to be eaten by a grue.
            Player pc = new Player();

            pc.Luck = 10;
            pc.AttackLevel = 10;

            Console.WriteLine("Greetings traveler.? \n"+ "What is your name?");
            pc.Name = Console.ReadLine();
            Console.WriteLine($"\n\nNice to meet you, {pc.Name}.");

            Console.WriteLine("\nWhere do your talents lie?\n" + 
                "1: The battlefield\n" +
                "2: Magical skill\n" +
                "3: ...Other pursuits.");

            Player.Specialization = int.Parse(Console.ReadLine());
        }
    }
}
