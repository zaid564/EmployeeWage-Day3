using System;

namespace EmployeeUC1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Employee_IS_PRESENT = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == Employee_IS_PRESENT)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}
