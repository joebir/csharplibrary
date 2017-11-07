using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._20_Interfaces
{
    class ArrayClass : IEnum, IList, ICollect
    {
        public void IterateOverCollection()
        {
            Console.WriteLine("You are iterating over the array.");
        }

        public void AddStuff()
        {
            Console.WriteLine("Added stuff to the array.");
        }

        public void RemoveStuff()
        {
            Console.WriteLine("Removed stuff from the array.");
        }

        public void CheckCount()
        {
            Console.WriteLine("Checking the count of the array.");
        }

        public void CheckCapacity()
        {
            Console.WriteLine("You can't check the capacity on an array.");
        }
    }
}
