using System;

namespace EmployeeWage
{
    class EmpWage
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Program");

            int isPresent = 1;
            int empWage = 0;
            int ratePerHrs = 20;
            int empHrs = 0;
            Random random = new Random();
            int randominput = random.Next(0,2);

            if (randominput == isPresent)
            {
                Console.WriteLine("Employee is Present");
                empHrs = 8;
            }
            else 
            {
                Console.WriteLine("Employee is Absent");
                empHrs = 0;
            }
            empWage = ratePerHrs * empHrs;
            Console.WriteLine("Employee wage per day: " + empWage);
           
        }
    }
}
