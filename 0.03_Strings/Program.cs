using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._03_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string firstName;
            //string lastName;
            //string occupation;

            //firstName = "Fred";
            //lastName = "Rogers";
            //occupation = "TV personality";

            //string fullName = String.Concat(firstName, " ", lastName);
            //Console.WriteLine(fullName);

            //Console.WriteLine("Hello, my name is " + fullName + ". I am a " + occupation + ".");

            //String Interpolation
            //Console.WriteLine("Hello, my name is {0}. I am a {1}.", fullName, occupation);

            //Console.WriteLine($"Hello, my name is {fullName}. I am a {occupation}.");

            string employerName = "Mr. Jones";
            string date = DateTime.Now.ToString("MM" + "/" + "dd" + "/" + "yyyy");
            string language = "C#";
            string position = "developer";

            Console.WriteLine($"Dear {employerName},");
            Console.WriteLine($"Today is {date}. I'm enjoying class, and I think I like {language} the best.");
            Console.WriteLine($"I'd like to get a job as a {position} after I finish this course.");

            string lowercase = "jbir";
            string uppercase = "JBIR";

            bool isSame = lowercase.Equals(uppercase);

            Console.WriteLine($"Your username boolean return is: " + isSame + ".");
            Console.WriteLine($"Your username boolean return is: ");
        }
    }
}
