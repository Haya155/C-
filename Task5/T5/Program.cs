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
            Student student1 = new Student("Ahmad", 20, 90, "S101");
            Student student2 = new Student("Sara", 19, 95, "S102");

            student1.SetSchoolName("Yarmouk School");
            student2.SetSchoolName("Yarmouk School");

            student1.DisplayInfo();
            student1.DisplaySchoolName();

            Console.WriteLine();

            student2.DisplayInfo();
            student2.DisplaySchoolName();

            Console.WriteLine();

            Teacher teacher = new Teacher("Omar", 35, "C#");

            teacher.SetSchoolName("Yarmouk School");
            teacher.DisplayTeacherInfo();

            // SchoolName is protected, so Main cannot access it directly.
            // Console.WriteLine(student1.SchoolName); // Error

            // _internalCode is private inside Person.
            // Main cannot access it directly.
            // Console.WriteLine(student1._internalCode); // Error

            Console.WriteLine();

      
            SchoolReport report =
                new SchoolReport("Annual School Report");

            report.DisplayReportTitle();






        }
    }
}
