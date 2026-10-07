using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your Name:");
            string stdName =Console.ReadLine();
            Console.WriteLine("Please enter your Age:");
            int stdAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your Grade:");
            double stdGrade =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter your Average:");
            double stdAverage = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter your Gender:");
            string stdGender = Console.ReadLine();

            Console.WriteLine("===== Student Report =====\n");

            Console.WriteLine("Welcome " + stdName+"\n");
            Console.WriteLine("Name:" + stdName);
            Console.WriteLine("Age:" + stdAge);
            Console.WriteLine("Grade: " + stdGrade);
            Console.WriteLine("Average " + stdAverage);
            Console.WriteLine("Gender " + stdGender);

            Console.WriteLine("===== Name Information =====\n");
            Console.WriteLine("Origin Name: " + stdName + "\n");
            Console.WriteLine("Uppercase:" + stdName.ToUpper());
            Console.WriteLine("Lowercase:" + stdName.ToLower());
            Console.WriteLine("First Character:" + stdName[0]);
            Console.WriteLine("Simple Student Calculation\n");
            Console.WriteLine("Please enter your Avarge:");
            stdAverage= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Original Average:"+ stdAverage);
            double Bouns = 5;
            double newAvg = Bouns + stdAverage;
            Console.WriteLine("Bonus Marks:" + Bouns);
            Console.WriteLine("New Average: " + newAvg);
            Console.WriteLine(" Student Status\n");
            Console.WriteLine("New Average" + newAvg);
            Console.WriteLine("\n");
            if (newAvg >= 50)
            {
                Console.WriteLine("The Result: Passed");
            }
            else
            {
                Console.WriteLine("The Result: Failed");
            }
            if (stdAge >= 18)
            {
                Console.WriteLine("The Student is Adult");
            }
            else
            {
                Console.WriteLine("The Student is Minor");
            }






        }
    }
}
