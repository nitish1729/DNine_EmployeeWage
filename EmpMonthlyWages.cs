using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNine_EmployeeWage
{
    public class EmpMonthlyWages
    {
		int WorkingDayPerMonth = 20;
		int WagePerHrs = 20;
		int FullTime = 8;
		int PartTime = 4;
		int NoWork = 0;
	

		//void display()  // non-static method
        public EmpMonthlyWages()  // constructor
		{
			Random ran = new Random();

			int AttenCheck = ran.Next(3, 10);

			switch (AttenCheck)
			{
				case 8:
					Console.WriteLine("Emp is present ");
					Console.WriteLine("Employee monthly wage is :- " + (WorkingDayPerMonth * WagePerHrs * FullTime));
					break;

				case 4:
					Console.WriteLine("Emp is HalfDayWork ");
					Console.WriteLine("Employee monthly wage is :-" + (WorkingDayPerMonth * WagePerHrs * PartTime));
					break;

				default:

					Console.WriteLine("Emp is Absent  ");
					Console.WriteLine("Employee monthly wage is :- " + (WorkingDayPerMonth * WagePerHrs * NoWork));
					break;
			}
		}
		public static void Main()
		{
			EmpMonthlyWages wages = new EmpMonthlyWages();
			//wages.display();
		}
	}
}
