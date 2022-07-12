using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComp
{
    public class EmpWage
    {

        public static void GetEmpWage()
        {
            int empHrs = 0;
            int empWage_Per_hr = 20;
            int daily_Emp_Wage = 0;
            empHrs = 8;
            daily_Emp_Wage = empHrs * empWage_Per_hr;
            Console.WriteLine("Daily Employee Wage is : " + daily_Emp_Wage);
        }
    }
}