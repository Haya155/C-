using System;

namespace task3
{
    internal class Program
    {
        static void guessingGame()
        {
            Random rand = new Random();
            int target = rand.Next(50, 76);
            int guess = 0;
            int attempts = 0;

            Console.WriteLine("Enter a random number between 50 and 75.");

            while (guess != target)
            {
                Console.WriteLine("Enter your guess:");
                guess = Convert.ToInt32(Console.ReadLine());

                attempts++;

                if (guess < target)
                {
                    Console.WriteLine("Write a higher number please.");
                    Console.WriteLine("Hint: The secret number is HIGHER than your guess.\n");
                }
                else if (guess > target)
                {
                    Console.WriteLine("Write a lower number please.");
                    Console.WriteLine("Hint: The secret number is LOWER than your guess.\n");
                }
                else
                {
                    int points = 0;
                    if (attempts == 1) points = 10;
                    else if (attempts == 2) points = 7;
                    else if (attempts == 3) points = 5;
                    else points = 0;

                    Console.WriteLine("\nCongratulations! You guessed it right!");
                    Console.WriteLine("Total Attempts: " + attempts);
                    Console.WriteLine("Points Earned: " + points);
                }
            }
        }

        static void student()
        {
            string[] stdarray = { "Ali", "Haya", "Ammer", "Mohammed", "Yousef" };
            Console.WriteLine("\n--- Student List ---");
            for (int i = 0; i < stdarray.Length; i++)
            {
                Console.WriteLine($"Student {i + 1}: {stdarray[i]}");
            }
        }

        static void studentgrade()
        {
            int[] stdarray = { 80, 98, 96, 88, 85 };
            Console.WriteLine("\n--- Student Grade ---");
            int studentNumber = 1;
            foreach (int i in stdarray)
            {
                Console.WriteLine($"Student {studentNumber}: {i}");
                studentNumber++;
            }
        }

        static void searchStudent()
        {
            string[] students = { "Ali", "Haya", "Ammar", "Mohammed", "Yousef" };

            Console.WriteLine("\nPlease enter a name to search:");
            string searchName = Console.ReadLine();

            bool isFound = false;

            foreach (string name in students)
            {
                if (name.Equals(searchName, StringComparison.OrdinalIgnoreCase))
                {
                    isFound = true;
                    break;
                }
            }

            if (isFound)
            {
                Console.WriteLine("Student Found!");
            }
            else
            {
                Console.WriteLine("Student Not Found.");
            }
        }

        static void checkResult()
        {
            Console.WriteLine("\nEnter the student's grade (0-100):");
            int grade = Convert.ToInt32(Console.ReadLine());

            if (grade >= 90 && grade <= 100)
            {
                Console.WriteLine("Excellent");
            }
            else if (grade >= 80 && grade <= 89)
            {
                Console.WriteLine("Very Good");
            }
            else if (grade >= 70 && grade <= 79)
            {
                Console.WriteLine("Good");
            }
            else if (grade >= 60 && grade <= 69)
            {
                Console.WriteLine("Pass");
            }
            else if (grade >= 0 && grade < 60)
            {
                Console.WriteLine("Fail");
            }
            else
            {
                Console.WriteLine("Invalid grade! Please enter a number between 0 and 100.");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=== Welcome to Part 1: Guessing Game ===");
            guessingGame();

            int choice=1;
            while (choice != 4)
            {
                Console.WriteLine("\n===== School System =====");
                Console.WriteLine("1. Display Students");
                Console.WriteLine("2. Search for Student");
                Console.WriteLine("3. Check Student Result");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter your choice (1-4):");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        student();
                        studentgrade();
                        break;
                    case 2:
                        searchStudent();
                        break;
                    case 3:
                        checkResult();
                        break;
                    case 4:
                        Console.WriteLine("Exiting the system. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Please choose a number between 1 and 4.");
                        break;
                }

            } 
        }
    }
}