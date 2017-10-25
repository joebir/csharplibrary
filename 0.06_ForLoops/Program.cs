using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i += 2)
            {
                Console.WriteLine(i);
            }

            for (int i = 10; i >= 0; i--)
            {
                switch (i)
                {
                    case 0:
                        Console.WriteLine("Houston, we have liftoff.");
                        break;
                    default:
                        Console.WriteLine(i);
                        break;
                }
            }
            Console.ReadLine();

            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i <= 100; i += 5)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            int num1 = 0;
            int num2 = 1;
            int total = 0;

            for (int i = 0; i <= 4000000;)
            {
                i = num1 + num2;

                if (i % 2 == 0)
                {
                    total += i;
                }

                num1 = num2;
                num2 = i;
            }

            Console.WriteLine(total);
            total = 0;

            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    total += i;
                }
            }

            Console.WriteLine(total);
        }
    }
}
