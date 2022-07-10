using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNine_EmployeeWage
{
    public class TotalEmpWageshundredHrs
    {
        const int MaxWorkingHrs = 100;
        const int WagePerHrs = 20;
        const int WorkingDays = 20;
        const int FullTime = 8;
        const int PartTime = 4;
        const int NoWork = 0;

		public TotalEmpWageshundredHrs()
		{
			int totalWorkingDay = 0, totalEmpHrs = 0;
			while (totalEmpHrs <= MaxWorkingHrs && totalWorkingDay < WorkingDays)
			{
				totalWorkingDay++;
				Random random = new Random();
				int AttenCheck = random.Next(0, 3);
				switch (AttenCheck)
				{
					case 8:
						Console.WriteLine("Emp is present ");
						Console.WriteLine("Total Wage : " + (WagePerHrs * FullTime));
						break;

					case 4:
						Console.WriteLine("Emp is HalfDayWork ");
						Console.WriteLine("Total Wage : " + (WagePerHrs * PartTime));
						break;

					default:

						Console.WriteLine("Emp is Absent  ");
						Console.WriteLine("Total Wage : " + (WagePerHrs * NoWork));
						break;
				}
			}
		}
    }
}
