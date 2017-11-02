using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._17_Override
{
    class Triangle: Shape
    {
        public Triangle(int side1, int side2, int side3)
        {
            this.Side1 = side1;
            this.Side2 = side2;
            this.Side3 = side3;
        }

        public int Side1 { get; set; }
        public int Side2 { get; set; }
        public int Side3 { get; set; }

        public override double Area()
        {
            double p = (this.Side1 + this.Side2 + this.Side3) / 2;
            double a = p - this.Side1;
            double b = p - this.Side2;
            double c = p - this.Side3;

            return Math.Sqrt(p * a * b * c);
        }
    }
}
