using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    internal class Student
    {
        public string Name;
        public int Age;
        public double Grade;

        public Student(string n, int a,double g)
        {
            Name = n;
            Age = a;
            Grade = g;
        }
        public void DisplayInfo()
        {

            Console.WriteLine("Students Information: " + "\n"+"Name:"+Name +"\n" +"Age:"+ Age +"\n" + "Grade:"+ Grade);

        }
    }
}
