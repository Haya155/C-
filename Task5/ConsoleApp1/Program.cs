using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();

            s1.Name = "Marwa";
            s1.Grade = 95;
            s1.ShowInfo();
        }
    }
}
