using System;
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
                EmpWage.GetEmpWage();
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Employe is Absent");
            }
        }
    }
}