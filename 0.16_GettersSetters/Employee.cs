using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._16_GettersSetters
{
    class Employee
    {
        //public string Name { get; set; }
        //public int ID { get; set; }
        private int _id;
        private string _name;
        private string _workQuote;

        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("The employee ID is invalid.");

                }

                _id = value;
            }
        }


        public string Name
        {
            get { return _name; }
            set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("The employee name is invalid.");
                }
                _name = value.Trim().ToLower();
            }
        }

        public void SetWorkQute(string quote)
        {
            this._workQuote = quote;
        }

        public string GetQuote()
        {
            return this._workQuote;
        }
    }
}
