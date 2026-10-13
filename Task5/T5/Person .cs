
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace T5
{
    internal class Person
    {
        public string Name { get; set; }

        private int _internalCode;

        // This field is private, so it can only be accessed directly
        // inside Person, not from Main or derived classes.

        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 0)
                    age = value;
                else
                    throw new ArgumentException("Invalid data");
            }
        }

        protected string SchoolName { get; set; }

        public Person(string n, int a)
        {
            Name = n;
            Age = a;
        }

        public void SetSchoolName(string schoolName)
        {
            SchoolName = schoolName;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("The name is: " + Name +
                              "\nThe age is: " + Age);
        }
    }
}

