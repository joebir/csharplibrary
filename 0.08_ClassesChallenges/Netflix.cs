using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._08_ClassesChallenges
{
    class Netflix
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public double Rating { get; set; }

        public string checkRating()
        {
            if(Rating >= 4)
            {
                return ("You should probably watch " + Name + ".");
            }

            else
            {
                return ("You can pretty safely skip " + Name + ".");
            }
        }
    }
}
