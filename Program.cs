using System;

namespace EmployeeWages
{
    class Program
    {
        static void Main(String[] args)
        {
            ForMultipleCompanies.computeEmpWage("Google", 25, 3, 10);
            ForMultipleCompanies.computeEmpWage("Facebook", 11, 4, 20);
        }
    }
}