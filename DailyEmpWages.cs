using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNine_EmployeeWage
{
    public class DailyEmpWages
    {
        int WagePerHrs = 20;
        int FullTime = 8;
        int NoWork = 0;

        public DailyEmpWages() // constructor
        {
            Random ran = new Random();

            int AttenCheck = ran.Next(5, 10);

            if (AttenCheck == FullTime)
            {
                Console.WriteLine("Emp is Present");
                Console.WriteLine("Employee daily wages is- : " + (WagePerHrs * FullTime));
            }
            else
            {
                Console.WriteLine("Emp is Absent");
                Console.WriteLine("EmpWage : " + (WagePerHrs * NoWork));
            }
        }
        public static void Main(string[] args)
        {
            DailyEmpWages wages = new DailyEmpWages();

        }
    }

}  

