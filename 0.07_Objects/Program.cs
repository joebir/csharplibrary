using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Donut paulDonut = new Donut();
            Donut kennDonut = new Donut();
            Donut jayDonut = new Donut();

            paulDonut.Type = "Jelly";
            paulDonut.Filling = "Cherry Jelly";
            paulDonut.Price = 7.99m;
            paulDonut.isSpecial = true;

            kennDonut.Type = "Jelly";
            kennDonut.Filling = "Strawberry Jelly";
            kennDonut.Price = 0.00m;
            kennDonut.isSpecial = false;

            jayDonut.Type = "Angel";
            jayDonut.Filling = "Cremé";
            jayDonut.Price = 3.50m;
            jayDonut.isSpecial = true;


            Console.WriteLine(paulDonut);
            Console.WriteLine(paulDonut.Filling);
        }
    }
}
