using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._19_QuizOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle t1 = new Triangle(5, 5);
            Triangle t2 = new Triangle(6, 2);
            Triangle t3 = new Triangle(4, 8);
            Triangle t4 = new Triangle(9, 10);
            Triangle t5 = new Triangle(3, 6);

            Triangle[] triangles = { t1, t2, t3, t4, t5 };

            foreach (Triangle triangle in triangles)
            {
                Console.WriteLine(triangle.AreaMethod());
            }
        }
    }
}
