using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._11_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student jayStudent = new Student("Jay", "Jackson", 1, 5);
            //Student joeStudent = new Student("Joe", "Bir", 12);


            //Bronze
            MobilePhone joePhone = new MobilePhone("Joe", "Samsung", "Galaxy S5 Active");
            MobilePhone codyPhone = new MobilePhone("Cody", "Samsung", "Galaxy S8");
            MobilePhone rachelPhone = new MobilePhone("Rachel", "iPhone", "5");
            MobilePhone jamiePhone = new MobilePhone("Jamie", "iPhone", "6");
            MobilePhone kevinPhone = new MobilePhone("Kevin", "Samsung", "Galaxy S8");

            //Console.WriteLine(joePhone.GetPhone());

            List<MobilePhone> phoneList = new List<MobilePhone>() { joePhone, codyPhone, rachelPhone, jamiePhone, kevinPhone };

            foreach (MobilePhone phone in phoneList)
            {
                Console.WriteLine(phone.GetPhone());
            }
        }
    }
}
