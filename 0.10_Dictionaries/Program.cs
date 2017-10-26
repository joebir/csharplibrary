using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> winners = new Dictionary<int, string>();


            winners.Add(2000, "Gladiator");
            winners.Add(2001, "A Beautiful Mind");
            winners.Add(2002, "Chicago");
            winners.Add(2003, "The Lord of the Rings: The Return of the King");
            winners.Add(2004, "Million Dollar Baby");
            winners.Add(2005, "Crash");
            winners.Add(2006, "The Departed");
            winners.Add(2007, "No Country for Old Men");
            winners.Add(2008, "Slumdog Millionaire");
            winners.Add(2009, "The Hurt Locker");
            winners.Add(2010, "The King's Speech");
            winners.Add(2011, "The Artist");
            winners.Add(2012, "Argo");
            winners.Add(2013, "12 Years a Slave");
            winners.Add(2014, "Birdman");
            winners.Add(2015, "Spotlight");
            winners.Add(2016, "Moonlight");

            //foreach (KeyValuePair<int, string> element in winners)
            //{
            //    Console.WriteLine($"{element.Key.ToString()}: {element.Value}");
            //}

            Dictionary<int, string[]> nominees = new Dictionary<int, string[]>();

            string[] twoK = { "Gladiator", "Chocolat", "Crouching Tiger, Hidden Dragon", "Erin Brockovich", "Traffic" };
            string[] twoKOne = { "A Beautiful Mind", "Gosford Park", "In the Bedroom", "TheLord of the Rings: The Fellowship of the Ring", "Moulin Rouge!" };
            string[] twoKTwo = { "Chicago", "Gangs of New York", "The Hours", "The Lord of the Rings: The Two Towers", "The Pianist" };
            string[] twoKThree = { "The Lord of the Rings: The Return of the King", "Lost in Translation", "Master and Commander: The Far Side of the World", "Mystic River", "Seabiscuit" };
            string[] twoKFour = { "Million Dollar Baby", "The Aviator", "Finding Neverland", "Ray", "Sideways" };
            string[] twoKFive = { "Crash", "Brokeback Mountain", "Capote", "Good Night, and Good Luck", "Munich" };
            string[] twoKSix = { "The Departed", "Babel", "Letters from Iwo Jima", "Little Miss Sunshine", "The Queen" };
            string[] twoKSeven = { "No Country for Old Men", "Atonement", "Juno", "Michael Clayton", "There Will Be Blood" };
            string[] twoKEight = { "Slumdog Millionaire", "The Curious Case of Benjamin Button", "Frost/Nixon", "Milk", "The Reader" };
            string[] twoKNine = { "The Hurt Locker", "Avatar", "The Blind Side", "District 9", "An Education", "Inglorious Basterds", "Precious", "A Serious Man", "Up", "Up in the Air" };
            string[] twoKTen = { "The King's Speech", "127 Hours", "Black Swan", "The Fighter", "Inception", "The Kids Are All Right", "The Social Network", "Toy Story 3", "True Grit", "Winter's Bone" };
            string[] twoKEleven = { "The Artist", "The Descendants", "Extremely Loud and Incredibly Close", "The Help", "Hugo", "Midnight in Paris", "Moneyball", "The Tree of Life", "War Horse" };
            string[] twoKTwelve = { "Argo", "Amour", "Beasts of the Southern Wild", "Django Unchained", "Les Misérables", "Life of Pi", "Lincoln", "Silver Linings Playbook", "Zero Dark Thirty" };
            string[] twoKThirteen = { "12 Years a Slave", "American Hustle", "Captain Phillips", "Dallas Buyers Club", "Gravity", "Her", "Nebraska", "Philomena", "The Wolf of Wall Street" };
            string[] twoKFourteen = { "Birdman", "American Sniper", "Boyhood", "The Grand Budapest Hotel", "The Imitation Game", "Selma", "The Theory of Everything", "Whiplash" };
            string[] twoKFifteen = { "Spotlight", "The Big Short", "Bridge of Spies", "Brookly", "Mad Max: Fury Road", "The Martian", "The Revenant", "Room" };
            string[] twoKSixteen = { "Moonlight", "Arrival", "Fences", "Hacksaw Ridge", "Hell or High Water", "Hidden Figures", "La La Land", "Lion", "Manchester by the Sea" };

            nominees.Add(2000, twoK);
            nominees.Add(2001, twoKOne);
            nominees.Add(2002, twoKTwo);
            nominees.Add(2003, twoKThree);
            nominees.Add(2004, twoKFour);
            nominees.Add(2005, twoKFive);
            nominees.Add(2006, twoKSix);
            nominees.Add(2007, twoKSeven);
            nominees.Add(2008, twoKEight);
            nominees.Add(2009, twoKNine);
            nominees.Add(2010, twoKTen);
            nominees.Add(2011, twoKEleven);
            nominees.Add(2012, twoKTwelve);
            nominees.Add(2013, twoKThirteen);
            nominees.Add(2014, twoKFourteen);
            nominees.Add(2015, twoKFifteen);
            nominees.Add(2016, twoKSixteen);


            foreach(KeyValuePair<int, string[]> element in nominees)
            {
                Console.WriteLine(element.Key + ":" + String.Join(", ", element.Value));
            }

            Console.WriteLine("Please type a year after 1999 to see the winner of the Acadmey Award for Best Picture:");
            int year = Convert.ToInt32(Console.ReadLine());

            while (winners.ContainsKey(year) == false)
            {
                Console.WriteLine("Please type a year after 1999 to see the winner of the Acadmey Award for Best Picture:");
                year = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(winners[year]);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Please type a year after 1999 to see the nominees for the Acadmey Award for Best Picture:");
            year = Convert.ToInt32(Console.ReadLine());

            while (nominees.ContainsKey(year) == false)
            {
                Console.WriteLine("Please type a year after 1999 to see the nominees for the Acadmey Award for Best Picture:");
                year = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(year + ": " + String.Join(", ", nominees[year]));
        }
    }
}
