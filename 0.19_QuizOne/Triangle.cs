using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._19_QuizOne
{
    class Triangle: Shape
    {
        public Triangle(int tBase, int tHeight)
        {
            this.TBase = tBase;
            this.THeight = tHeight;
        }

        public int TBase { get; set; }
        public int THeight { get; set; }

        public override double AreaMethod()
        {
            this.Area = (TBase * THeight) / 2;
            return this.Area;
        }
    }
}
