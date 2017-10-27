using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._11_Constructors
{
    class MobilePhone
    {
        public MobilePhone(string owner, string make, string model)
        {
            this.Owner = owner;
            this.Make = make;
            this.Model = model;
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public string Owner { get; set; }

        char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

        public string GetPhone()
        {
            if(Make.IndexOfAny(vowels) == 0)
            {
                return ($"{Owner} owns an {Make} {Model}.");
            }

            else
            {
                return($"{Owner} owns a {Make} {Model}.");
            }
        }
    }
}
