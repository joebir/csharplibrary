using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._17_Override
{
    class Program
    {
        static void Main(string[] args)
        {
            Square box = new Square(4);
            Circle round = new Circle(3);
            Triangle three = new Triangle(18, 24, 30);

            Console.WriteLine(three.Area());
        }
    }
}
