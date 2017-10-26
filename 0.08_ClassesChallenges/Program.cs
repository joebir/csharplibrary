using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._08_ClassesChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Netflix leverage = new Netflix();
            Netflix archer = new Netflix();
            Netflix ironFist = new Netflix();

            leverage.Name = "Leverage";
            leverage.Genre = "Crime";
            leverage.Rating = 4.0d;

            archer.Name = "Archer";
            archer.Genre = "Comedy";
            archer.Rating = 4.6d;

            ironFist.Name = "Iron Fist";
            ironFist.Genre = "Superhero";
            ironFist.Rating = 2.3d;

            Console.WriteLine(leverage.checkRating());
            Console.WriteLine(archer.checkRating());
            Console.WriteLine(ironFist.checkRating());

            List<Netflix> shows = new List<Netflix>
            {
                leverage,
                archer,
                ironFist
            };

            foreach (Netflix element in shows)
            {
                Console.WriteLine("Name: " + element.Name);
                Console.WriteLine("Genre: " + element.Genre);
                Console.WriteLine("Rating: " + element.Rating);
                Console.WriteLine();
            }
        }
    }
}
