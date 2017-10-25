using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._03_PairCodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How are you feeling today from 1-5?");
            string feeling = Console.ReadLine();

           if (feeling == "1") {
                Console.WriteLine("I'm really sorry to hear that. Is there anything I can do to help?");
            }
            else if(feeling == "2") {
                Console.WriteLine("Oh. Well, I hope the rest of the day treats you better.");
            }
            else if(feeling == "3") {
                Console.WriteLine("Well, no news is good news? Does that make any sense?");
            }
            else if(feeling == "4") {
                Console.WriteLine("Hey, good for you. I'm glad you're having a good day.");
            }
            else if(feeling == "5") {
                Console.WriteLine("Wow! It sounds like you're having a stellar day today. I hope it stays that way.");
            }
           else {
                Console.WriteLine("I couldn't quite hear you. I'll ask you again if you want me to!");
            }

            Console.ReadLine();
        }
    }
}
