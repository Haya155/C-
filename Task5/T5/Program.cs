using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create two Student objects
            Student student1 = new Student("Ahmad", 20, 90, "S101");
            Student student2 = new Student("Sara", 19, 95, "S102");

            // Set the school name
            student1.SetSchoolName("Yarmouk School");
            student2.SetSchoolName("Yarmouk School");

            // Display student information
            student1.DisplayInfo();
            student1.DisplaySchoolName();

            Console.WriteLine();

            student2.DisplayInfo();
            student2.DisplaySchoolName();

            Console.WriteLine();

            // Create a Teacher object
            Teacher teacher = new Teacher("Omar", 35, "C#");

            teacher.SetSchoolName("Yarmouk School");
            teacher.DisplayTeacherInfo();

            // SchoolName is protected, so Main cannot access it directly.
            // Console.WriteLine(student1.SchoolName); // Error

            // _internalCode is private inside Person.
            // Main cannot access it directly.
            // Console.WriteLine(student1._internalCode); // Error

            Console.WriteLine();

            // Create a SchoolReport object
            SchoolReport report =
                new SchoolReport("Annual School Report");

            report.DisplayReportTitle();






        }
    }
}
