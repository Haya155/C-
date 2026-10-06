using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolSystem__Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Information\n");
            string stdName = "Haya Ahmed";
            int stdAge = 24;
            double stdGrade = 95;
            double stdAvg = 83.4;
            string stdGender = "Female";
            bool isStdActive = true;

            Console.WriteLine("StdName:"+ stdName);
            Console.WriteLine("StdAge:" + stdAge);
            Console.WriteLine("stdGrade:" + stdGrade);
            Console.WriteLine("stdAvg:" + stdAvg);
            Console.WriteLine("stdGender:" + stdGender);
            Console.WriteLine("isStdActive:" + isStdActive);

            //Part Two
            Console.WriteLine("\n");
            string[] students = { "Haya", "Sara", "Deema","Ammar" };
            Console.WriteLine("student1:" + students[0]);
            Console.WriteLine("student2:" + students[1]);
            Console.WriteLine("student3:" + students[2]);
            Console.WriteLine("student4:" + students[3]);
            Console.WriteLine("studentLength:" + students.Length);

            //Part Three
            Console.WriteLine("\n");
            Console.WriteLine("student1:" + students[0]);
            Console.WriteLine("student4:" + students[3]);
            students[1] = "Mohammed";

            Console.WriteLine("\nstudent1:" + students[0]);
            Console.WriteLine("student2:" + students[1]);
            Console.WriteLine("student3:" + students[2]);
            Console.WriteLine("student4:" + students[3]);




        }
    }
}
