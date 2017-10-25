using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._02_BasicTypesChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int integer1;
            int integer2 = 6;
            string text1;
            string text2 = "Look at me, I'm a string!";
            bool boolean1;
            bool boolean2 = false;
            float single1;
            float single2 = 3.2f;
            double dbl1;
            double dbl2 = 12.1;
            decimal dec1;
            decimal dec2 = 13.7m;

            Console.WriteLine(integer2);
            Console.WriteLine(text2);
            Console.WriteLine(boolean2);
            Console.WriteLine(single2);
            Console.WriteLine(dbl2);
            Console.WriteLine(dec2);

            text1 = "Look at me,";
            text2 = " I'm a string!";

            Console.WriteLine(text1);
            Console.WriteLine(text2);
            Console.WriteLine(String.Concat(text1, text2));

            string birth = "1994";
            int bday = Convert.ToInt32(birth);
            Console.WriteLine("I was born in " + bday + ".");
        }
    }
}
