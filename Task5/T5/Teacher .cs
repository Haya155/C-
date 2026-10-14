using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace T5
{
    internal class Teacher : Person
    {
        public string Subject { get; set; }

        public Teacher(string name, int age, string subject)
            : base(name, age)
        {
            Subject = subject;
        }

        public void DisplayTeacherInfo()
        {
            Console.WriteLine("The name is: " + Name +   "\nThe age is: " + Age + "\nThe subject is: " + Subject);
        }
    }
}
