
using System;

class Student
{
    private int grade;

    // Auto-property
    public string Name { get; set; }

    // Property
    public int Grade
    {
        get { return grade; }
        set
        {
            if (value >= 0 && value <= 100)

                grade = value;
            else
            {
                Console.WriteLine("Invalid value!");
            }
           
        }
          
    }

    private int age = 23;

    protected string City = "Irbid";

    public void ShowInfo()
    {
        Console.WriteLine(Name);
        Console.WriteLine(Grade);
        Console.WriteLine(age);
        Console.WriteLine(City);
    }
}