using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._20_Interfaces
{
    class ListClass : IEnum, IList, ICollect
    {
        public void IterateOverCollection()
        {
            Console.WriteLine("Iterating over the collection.");
        }

        public void AddStuff()
        {
            Console.WriteLine("Adding stuff to the list.");
        }

        public void RemoveStuff()
        {
            Console.WriteLine("Removing stuff from the list.");
        }

        public void CheckCount()
        {
            Console.WriteLine("Checking the count of the list.");
        }

        public void CheckCapacity()
        {
            Console.WriteLine("Checking the capacity of the list.");
        }
    }
}
