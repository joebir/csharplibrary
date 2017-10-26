using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] foods = new string[] { "Dark chocolate", "Moroccan chicken", "Truffle risotto" };
            foreach(string element in foods)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine();

            int[] numArray1 = new int[] { 2, 4, 6, 1, 3 };
            int[] numArray2 = new int[] { 1, 3, 6, 4, 2 };
            int[] numArray3 = new int[] { numArray1[0] + numArray2[0], numArray1[1] + numArray2[1], numArray1[2] + numArray2[2], numArray1[3] + numArray2[3], numArray1[4] + numArray2[4] };

            foreach (int element in numArray3)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine();

            int[] randoArray = new int[10];
            Random randoCalrissian = new Random();

            for (int i = 0; i < randoArray.Length; i++)
            {
                randoArray[i] = randoCalrissian.Next(0,100);
            }

            foreach (int element in randoArray)
            {
                Console.WriteLine(element);
            }
        }
    }
}
