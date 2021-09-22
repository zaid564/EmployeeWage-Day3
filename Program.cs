using System;

namespace EmployeeWageUC3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Constant variables
            int ISPartTime = 1;
            int ISFullTime = 2;
            int EmpRatePerHour = 20;

            //Variables
            int EmpHrs = 0;
            int EmpWage = 0;

            Random random = new Random();

            int EmpCheck = random.Next(0, 3);
            Console.WriteLine("Random number :" + EmpCheck);

            if (EmpCheck == ISPartTime)
            {
                EmpHrs = 4;
            }
            else if (EmpCheck == ISFullTime)
            {
                EmpHrs = 8;
            }
            else
            {
                EmpHrs = 0;
            }
            EmpWage = EmpHrs * EmpRatePerHour;
            Console.WriteLine("Emp Wage :" + EmpWage);

        }
    }
}
