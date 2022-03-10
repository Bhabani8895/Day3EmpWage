using System;

namespace EmployeeWage
{
    class EmpWage
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Program");

            int isPresent = 1;
            Random random = new Random();
            int randominput = random.Next(0,2);

            if (randominput == isPresent)
            {
                Console.WriteLine("Employee is Present");
            }
            else 
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
