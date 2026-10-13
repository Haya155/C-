
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace T5
{
    internal class Student : Person
    {
        public int Grade { get; set; }
        public string StudentId { get; set; }

        public Student(string name, int age, int grade, string studentId)
            : base(name, age)
        {
            Grade = grade;
            StudentId = studentId;
        }

        public void DisplaySchoolName()
        {
            Console.WriteLine("School Name: " + SchoolName);
        }
    }
}
