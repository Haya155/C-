using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            Student std1=new Student("Haya",24,99);
            Student std2 = new Student("Deema", 28, 92);
            Student std3 = new Student("Ammar", 30, 80);
            Student std4 = new Student("Mohammed", 22, 98);
            std1.DisplayInfo();
            std2.DisplayInfo();
            std3.DisplayInfo();
            std4.DisplayInfo();

        }
    }
}
