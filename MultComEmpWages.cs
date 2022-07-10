using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNine_EmployeeWage
{
    public class MultComEmpWages
    {
        public const int FullTimeHrs = 8;
        public const int PartTimeHrs = 4;
        public const int NoworkHrs = 0;
        public int wagePerHrs;
        public int workingdays;
        public int workinHrsPerMonth;

        static void company()
        {
            Console.WriteLine("Enter wagePerHrs");
            int wagePerHrs = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Workingdays");
            int workingdays = int.Parse(Console.ReadLine());
            Console.WriteLine("workinHrsPerMonth");
            int workinHrsPerMonth = int.Parse(Console.ReadLine());
            int empwages = FullTimeHrs * wagePerHrs * workingdays * workinHrsPerMonth;
            Console.WriteLine("Emp Total Monthly wages:-" + empwages);
        }
        public static void Main(string[] args)
        {
            MultComEmpWages com1 = new MultComEmpWages();
            MultComEmpWages.company();

        }
    }
}
