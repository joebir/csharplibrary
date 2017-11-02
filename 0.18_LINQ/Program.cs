using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._18_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] instructors = { "Jay", "Paul", "Kenn", "Christoph", "Auri" };

            //IEnumerable<String> query = from i in instructors
            //                            where i.Length == 4
            //                            select i;

            //foreach (string name in query)
            //{
            //    Console.WriteLine(name);
            //}

            IEnumerable<Employee> employees = new List<Employee>()
            {
                new Employee {ID=1,Name="Johnboy",HireDate=new DateTime(2015,3,5)},
                new Employee {ID=2,Name="Edboy",HireDate=new DateTime(2016,2,17)},
                new Employee {ID=3,Name="Rolphboy",HireDate=new DateTime(2012,1,18)}
            };

            IEnumerable<Employee> eQuery = from i in employees
                                           where i.HireDate.Year == 2016
                                           orderby i.Name ascending
                                           select i;

            foreach(Employee employee in eQuery)
            {
                Console.WriteLine(employee.Name);
            }
        }
    }
}
