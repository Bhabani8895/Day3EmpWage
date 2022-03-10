using System;

namespace EmployeeWage
{
    public class EmpWage
    {
        public const int is_Full_Time = 1;
        public const int is_Part_Time = 2;
        public const int ratePerHrs = 20;
        public const int max_Working_Days = 20;

        public static void Main(string[] args)
        {
            int empWage = 0;
            int empHrs = 0;
            int totalEmpWage = 0;
            string typeOfEmployee = "";
          
            Random employee = new Random();
            for (int day = 1; day <= max_Working_Days; day++)
            {
                int randomInput = employee.Next(0, 3);

                switch (randomInput)
                {
                    case is_Full_Time:
                        empHrs = 8;
                        typeOfEmployee = "Full Time";
                        break;

                    case is_Part_Time:
                        empHrs = 4;
                        typeOfEmployee = "Part Time";
                        break;

                    default:
                        empHrs = 0;
                        typeOfEmployee = "Absent";
                        break;
                }
                empWage = ratePerHrs * empHrs;
                Console.WriteLine("{0}Emplyee of day: {1}wage is {2}", typeOfEmployee, day, empWage);
                totalEmpWage = totalEmpWage + empWage;
            }
            Console.WriteLine("Employee wage for {0} day is : {1}", max_Working_Days, totalEmpWage);
        }
    }
}