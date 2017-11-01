using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._16_GettersSetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee jay = new Employee();

            Console.WriteLine("Enter Employee Name: ");
            jay.Name = Console.ReadLine();

            Console.WriteLine("Enter Employee ID: ");
            jay.ID = Int32.Parse(Console.ReadLine());

            Console.WriteLine(jay.Name);
            Console.WriteLine(jay.ID);

            Console.WriteLine($"Enter a common quote for {jay.Name}");
            jay.SetWorkQuote(Console.ReadLine());

            Console.WriteLine(jay.GetQuote());
        }
    }
}
