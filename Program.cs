using System;

namespace EmployeeWages
{
    class Program
    {
        static void Main(String[] args)
        {
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addCompanyEmpWage("Google", 25, 3, 10);
            empWageBuilder.addCompanyEmpWage("Facebook", 11, 4, 20);
            empWageBuilder.computeEmpWage();
        }
    }
}

