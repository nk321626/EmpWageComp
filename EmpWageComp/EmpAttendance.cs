﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComp
{
    public class EmpAttendance
    {
        const int EMP_PRESENT = 1;

        public static void GetEmpAttendance()
        {
            Random random = new Random();
            int randomInt = random.Next(0, 2);

            if (randomInt == EMP_PRESENT)
            {
                Console.WriteLine("Employee is Present");
                
                int empHrs = 0;
                int empWage_Per_hr = 20;
                int daily_Emp_Wage = 0;
                empHrs = 8;
                daily_Emp_Wage = empHrs * empWage_Per_hr;
                Console.WriteLine("Daily Employee Wage is : " + daily_Emp_Wage);
            }
            else
            {
                Console.WriteLine("Employe is Absent");
            }
        }
    }
}