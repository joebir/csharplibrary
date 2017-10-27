using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._11_Constructors
{
    class Student
    {
        public Student()
        {

        }
        public Student(string firstName)
        {
            this.FirstName = firstName;
        }
        public Student(int age, string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public Student(string firstName, string lastName, int grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }

        public Student(string firstName, string lastName, int age, int grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Grade = grade;
        }

        //Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }
    }
}
