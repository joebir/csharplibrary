using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._20_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayClass exampleArray = new ArrayClass();
            exampleArray.CheckCapacity();

            ListClass exampleList = new ListClass();
            exampleList.CheckCapacity();
        }
    }
}
