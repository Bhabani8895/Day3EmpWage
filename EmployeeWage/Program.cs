using System;

namespace EmployeeWage
{
    class EmpWage
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Program");

            int is_Full_Time = 1;
            int is_Half_Time = 2;
            int empWage = 0;
            int ratePerHrs = 20;
            int empHrs = 0;

            Random employee = new Random();
            int randomInput = employee.Next(0, 3);

            if (randomInput == is_Full_Time)
            {
                Console.WriteLine("Full Time Employee is Present");
                empHrs = 8;
            }
            else if (randomInput == is_Half_Time)
            {
                Console.WriteLine("Part Time Employee is Present");
                empHrs = 8 / 2;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            empWage = ratePerHrs * empHrs;
            Console.WriteLine("Employee wage per day: " + empWage);
           
        }
    }
}
